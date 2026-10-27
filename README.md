# SupabaseCrudLab

ASP.NET Core MVC + Entity Framework Core + PostgreSQL (Supabase) CRUD application for Lab 11.

## Before running

1. Open the project in Visual Studio 2022/2026.
2. Restore NuGet packages.
3. Create a Supabase project.
4. Get the Session Pooler connection details. Use port 5432.
5. Right-click the project > Manage User Secrets.
6. Put your real connection string in secrets.json:

{
  "ConnectionStrings": {
    "Supabase": "Host=YOUR_HOST;Port=5432;Database=postgres;Username=YOUR_USER;Password=YOUR_PASSWORD;SSL Mode=Require;Trust Server Certificate=true"
  }
}

Do not put the password in appsettings.json or GitHub.

## Migration

Open the terminal in the folder containing SupabaseCrudLab.csproj and run:

dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update

Then run the application and open Products.

## CRUD test

Create: Notebook, 250, 20
Read: confirm Notebook appears
Update: change price to 275
Delete: delete Notebook
Persistence: create again, stop and restart the app, then confirm it remains.
