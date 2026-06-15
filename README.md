# CI/CD Pipeline for .NET Web Application using Azure DevOps

A simple .NET 8 minimal API deployed to Azure App Service using a full CI/CD pipeline built with Azure DevOps.

---

## Tech Stack

- .NET 8 (ASP.NET Core Minimal API)
- Azure DevOps (CI/CD Pipelines)
- Azure App Service (Linux)
- GitHub (Source Repository)

---

## Project Structure

```
├── Program.cs               # ASP.NET Core minimal API entry point
├── Greeting.cs              # Static greeting message
├── HelloPrajwal.csproj      # .NET 8 Web SDK project file
├── azure-pipelines.yml      # CI pipeline
└── release-pipeline.yml     # CD pipeline
```

---

## CI Pipeline

Triggers on pushes to `main` for `Program.cs`, `Greeting.cs`, and `HelloPrajwal.csproj`.

- Restore dependencies
- Build application
- Publish application
- Package into `app.zip`
- Publish as pipeline artifact `dot-net-artifact`

---

## CD Pipeline

Triggers automatically when CI completes successfully on `main`.

| Stage | Environment | Trigger |
|-------|-------------|---------|
| Deploy to Dev | `Dev` | Automatic |
| Deploy to Production | `Production` | Manual approval required |

---

## How to Run Locally

```bash
git clone https://github.com/vprajwal27/Azure-DevOps--.NET-app.git
cd Azure-DevOps--.NET-app
dotnet restore HelloPrajwal.csproj
dotnet run --project HelloPrajwal.csproj
```

Open `http://localhost:5000` — you should see:

```
Hello world from Prajwal!
```
