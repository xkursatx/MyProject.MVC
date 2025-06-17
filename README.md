# .NET + React (Vite) Integration Sample

## Purpose

This repository demonstrates how to embed a React frontend (built with Vite) inside a .NET 9 Razor Pages project. The main goal is to provide a clear example of integrating a modern React (SPA) workflow with a .NET backend, including build and deployment processes.

---

## Project Structure

- **MyProject.MVC**: .NET 9 Razor Pages project serving as the backend and static file host.
- **react-client**: Sample React project using Vite for fast development and optimized builds.

---

## How It Works

- The React app is developed and built separately using Vite.
- On building the .NET project, a pre-build step automatically installs dependencies and builds the React app.
- The React build output is placed in `MyProject.MVC/wwwroot/client`, making it accessible as static files from the .NET app.
- The .NET app serves both Razor Pages and the embedded React frontend.

---

## Running the Projects

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Node.js & npm](https://nodejs.org/)

### Build & Run

1. **Restore and build everything (from the solution root):**
> The build process will automatically run `npm install` and `npm run build` in the `react-client` folder.

2. **Access the app:**
   - Razor Pages: [http://localhost:5000/](http://localhost:5000/) (or your configured port)
   - React frontend: [http://localhost:5000/client/](http://localhost:5000/client/)

---

## Vite Configuration Details

- **Config file:** `react-client/vite.config.js`
- **Base path:** `/client/` (ensures correct asset paths when served by .NET)
- **Build output:** `../MyProject.MVC/wwwroot/client`
- **Manifest:** Enabled for integration with .NET
- **Plugins:** `@vitejs/plugin-react` for React fast refresh and JSX support

---

## .NET Project Preferences

- **Target Framework:** net9.0
- **Nullable Reference Types:** Enabled
- **Implicit Usings:** Enabled
- **Pre-build Integration:** Custom MSBuild target runs Vite build before .NET build completes

---

## Summary

This setup provides a robust starting point for projects that require a modern React frontend within a .NET Razor Pages application, with automated build and deployment integration.