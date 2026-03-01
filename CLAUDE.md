# CLAUDE.md

## Project Overview

`msdos.html` is a self-contained MS-DOS terminal simulator built with vanilla HTML, CSS, and JavaScript. No frameworks, no build tools, no package managers.

The project also has a shared C# backend (`MsdosApi/`) hosted on Azure App Service (Free tier), backed by Supabase (PostgreSQL). The backend is the single API for all features that need persistence or server logic.

## Frontend

### Running locally
Open `msdos.html` directly in a browser. No server or build step required.

### Key constraints
- **Single file only** — all code lives in `msdos.html`. Do not create separate JS/CSS files.
- **No npm or bundlers** — there is no `package.json`, no build pipeline.
- **No external JS dependencies** — the only external resource is the Google Font (`Share Tech Mono`). Keep it that way.

### Code style
- Vanilla JS (ES6+), no TypeScript
- CSS is embedded in a `<style>` block in the same file
- Keep the retro CRT aesthetic intact (scanlines, vignette, monospace font, green/grey palette)
- `API_BASE` constant (in the `<script>` block) points to the Azure backend URL

## Backend (`MsdosApi/`)

- **Runtime**: .NET 10 Minimal API (C#)
- **Database**: Supabase (PostgreSQL) via direct Npgsql connection
- **Hosting**: Azure App Service, Free F1 tier — `https://msdos-web.azurewebsites.net`
- **Infrastructure**: defined in `infra/webapp.bicep`

### Connection string
Set as an Azure App Service config value (`SUPABASE_CONN`). Never committed to source.

### Current endpoints
| Method | Path | Description |
|---|---|---|
| GET | `/api/scores` | Top 10 Snake hi-scores |
| POST | `/api/scores` | Submit a Snake score |

## Deployment

| Workflow | File | Target | Trigger |
|---|---|---|---|
| Frontend | `deploy.yml` | GitHub Pages | Push to `main` |
| Backend | `deploy-backend.yml` | Azure App Service (`msdos-web`) | Push to `main` (paths: `MsdosApi/**`) |

### GitHub Secrets required
| Secret | Used by |
|---|---|
| `AZURE_APP_NAME` | `deploy-backend.yml` |
| `AZURE_PUBLISH_PROFILE` | `deploy-backend.yml` |

### Provision infrastructure (one-time)
```bash
az group create --name msdos-web-rg --location westeurope
az deployment group create --resource-group msdos-web-rg \
  --template-file infra/webapp.bicep --parameters appName=msdos-web
az webapp config appsettings set --name msdos-web --resource-group msdos-web-rg \
  --settings "SUPABASE_CONN=<connection-string>"
```

## What Claude Should Know

- This is a hobby/personal project — prioritize correctness and simplicity over cleverness
- Minimal changes preferred — don't refactor surrounding code when fixing a specific bug
- Don't add comments unless the logic genuinely needs explanation
