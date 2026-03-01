using Npgsql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(o => o.AddDefaultPolicy(p =>
    p.WithOrigins("https://bentkris.github.io")
     .AllowAnyMethod()
     .AllowAnyHeader()));

var connStr = builder.Configuration["SUPABASE_CONN"]
    ?? throw new InvalidOperationException("SUPABASE_CONN environment variable is not set.");

builder.Services.AddNpgsqlDataSource(connStr);

var app = builder.Build();
app.UseCors();

app.MapGet("/api/scores", async (NpgsqlDataSource db) =>
{
    await using var cmd = db.CreateCommand(
        "SELECT name, score FROM scores ORDER BY score DESC LIMIT 10");
    await using var r = await cmd.ExecuteReaderAsync();
    var list = new List<object>();
    while (await r.ReadAsync())
        list.Add(new { name = r.GetString(0), score = r.GetInt32(1) });
    return Results.Ok(list);
});

app.MapPost("/api/scores", async (ScoreEntry entry, NpgsqlDataSource db) =>
{
    if (string.IsNullOrWhiteSpace(entry.Name) || entry.Name.Length > 20 || entry.Score < 0)
        return Results.BadRequest("Invalid name or score.");

    await using var cmd = db.CreateCommand(
        "INSERT INTO scores (name, score) VALUES ($1, $2)");
    cmd.Parameters.AddWithValue(entry.Name.Trim().ToUpper());
    cmd.Parameters.AddWithValue(entry.Score);
    await cmd.ExecuteNonQueryAsync();
    return Results.Ok();
});

app.Run();

record ScoreEntry(string Name, int Score);
