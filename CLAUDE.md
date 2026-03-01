# CLAUDE.md

## Project Overview

`msdos.html` is a self-contained MS-DOS terminal simulator built with vanilla HTML, CSS, and JavaScript. No frameworks, no build tools, no package managers.

## Running the Project

Open `msdos.html` directly in a browser. No server or build step required.

## Key Constraints

- **Single file only** — all code lives in `msdos.html`. Do not create separate JS/CSS files.
- **No npm or bundlers** — there is no `package.json`, no build pipeline.
- **No external JS dependencies** — the only external resource is the Google Font (`Share Tech Mono`). Keep it that way.

## Code Style

- Vanilla JS (ES6+), no TypeScript
- CSS is embedded in a `<style>` block in the same file
- Keep the retro CRT aesthetic intact (scanlines, vignette, monospace font, green/grey palette)

## What Claude Should Know

- This is a hobby/personal project — prioritize correctness and simplicity over cleverness
- Minimal changes preferred — don't refactor surrounding code when fixing a specific bug
- Don't add comments unless the logic genuinely needs explanation
