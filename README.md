# Crimes of Edelweiss

A narrative detective mystery game built with **C# and Blazor WebAssembly**. Set at the University of Edelweiss, each chapter presents a brand new crime for you to investigate — explore the scene, examine evidence, and question witnesses to solve the case.

## About

The City of Edelweiss has a dark side. Behind its grandeur facade, a new mystery unfolds with every chapter — from disappearances to stranger crimes still to come.

Chapter 1 begins with the disappearance of Edel Winburg, the university principal's son, who vanished without a trace after a late-night study session in the computer laboratory. Future chapters bring entirely new cases, suspects, and secrets.

Explore locations, gather clues, and build your case file as each mystery unfolds.

## Features

- 🔍 **Investigation-driven gameplay** — examine locations, search for clues, and interview witnesses
- 📋 **Evidence collection system** — every clue you find is logged and tracked as you progress
- 📖 **Anthology-style chapters** — each chapter is a self-contained new crime, not one continuous case
- 🎨 **Atmospheric noir-inspired UI** — a detective corkboard aesthetic throughout

## Tech Stack

- **C#** / **.NET 8**
- **Blazor WebAssembly** — runs entirely client-side, no backend or database required
- **CSS** (Blazor CSS isolation for component-scoped styling)

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download) or later
- A code editor such as [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/) with the C# Dev Kit extension

### Running Locally

```bash
git clone https://github.com/fomalhautsanz/Crimes-of-Edelweiss.git
cd Crimes-of-Edelweiss/edelweiss
dotnet run
```

Then open the URL shown in your terminal (typically `https://localhost:5001` or similar) in your browser.

> **Tip:** Use `dotnet watch run` instead of `dotnet run` during development — it automatically rebuilds and refreshes the browser when you save changes.

## Project Structure

```
edelweiss/
├── Data/               # Game state and data models
│   ├── Evidence.cs
│   ├── GameState.cs
│   └── Suspect.cs
├── Layout/              # App shell (nav bar, sidebar, main layout)
│   ├── MainLayout.razor
│   └── NavMenu.razor
├── Pages/               # Game chapters / screens
│   └── One.razor
├── Resources/           # Images and static assets
└── wwwroot/             # Static web assets served to the browser
```

## Deployment

This project is built as a static Blazor WebAssembly app, meaning it can be hosted on any static file host — no server or database required. It's currently deployable via **GitHub Pages**.

## Acknowledgments

Built as part of an academic C#/.NET project.
