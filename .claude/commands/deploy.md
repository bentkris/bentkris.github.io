Deploy the project by committing all changes and pushing to main.

Steps:
1. Run `git status` and `git diff` to review what has changed.
2. Stage all modified tracked files (`git add -u`). Do NOT stage untracked files unless the user explicitly asks.
3. Draft a concise commit message that describes the changes (follow the style of recent commits).
4. Commit, then push. If the branch has no upstream yet, use `git push -u origin main`; otherwise use `git push`.
5. After pushing, tell the user which GitHub Actions workflows will be triggered based on what changed:
   - Changes to `msdos.html` or `staticwebapp.config.json` → **deploy-frontend.yml** (Azure Static Web Apps)
   - Changes under `MsdosApi/` → **deploy-backend.yml** (Azure App Service)
   - Both can trigger in the same push if files from both paths changed.
