using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

public class ApiTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public ApiTests(WebApplicationFactory<Program> factory)
    {
        _client = factory
            .WithWebHostBuilder(b => b.UseSetting("SUPABASE_CONN",
                "Host=localhost;Database=fake;Username=fake;Password=fake"))
            .CreateClient();
    }

    [Theory]
    [InlineData("", 100)]           // empty name
    [InlineData("   ", 100)]        // whitespace name
    [InlineData("AAAAAAAAAAAAAAAAAAAAAAA", 100)] // name > 20 chars
    [InlineData("VALID", -1)]       // negative score
    public async Task PostScore_InvalidInput_ReturnsBadRequest(string name, int score)
    {
        var response = await _client.PostAsJsonAsync("/api/scores", new { name, score });
        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }
}
