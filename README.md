# HMS - Hospital Management System

![.NET](https://img.shields.io/badge/.NET-10.0-blue)
![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET%20Core-MVC-success)

A simple ASP.NET Core MVC project for managing hospital patient records.

## Features

- Patient CRUD operations:
  - Create patient record
  - View patient list and details
  - Edit patient information
  - Delete patient record
- SQL Server integration with Entity Framework Core
- Basic validation using Data Annotations
- Mobile-friendly adjustments for patient pages

## Tech Stack

- ASP.NET Core MVC (.NET 10)
- Entity Framework Core
- SQL Server
- Bootstrap

## Project Structure

- `HMS.slnx`: Solution file
- `HMS/`: Main web application project
- `HMS/Controllers/`: MVC controllers
- `HMS/Models/`: Data models
- `HMS/Views/`: Razor views
- `HMS/wwwroot/`: Static assets (CSS/JS/libs)

## Prerequisites

- .NET SDK 10.0+
- SQL Server (local or remote)

## Configuration

Update connection string in `HMS/appsettings.json`:

```json
"ConnectionStrings": {
  "MyConnection": "Server=Localhost;trusted_connection=true;TrustServerCertificate=True;database=Patient"
}
```

## Database Setup

From the repository root:

```bash
dotnet restore HMS.slnx
dotnet ef database update --project HMS/HMS.csproj
```

## Run the Project

```bash
dotnet run --project HMS/HMS.csproj
```

Then open the URL shown in the terminal (usually `https://localhost:xxxx`).

## Notes

- This repository currently includes only basic functionality and can be extended with authentication/authorization and improved UI/UX.
- If needed for production, move sensitive settings to environment variables or user secrets.
