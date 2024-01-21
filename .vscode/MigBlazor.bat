@echo off
set /p migrationName="Enter Migration Name: "

if "%migrationName%"=="" (
    echo No migration name provided. Entity Framework migration command skipped for BlazorProject.
    goto Endpoint
)

dotnet ef migrations add %migrationName% --project "D:\FullStackPlus\ASP.NET\BlazorProject\BlazorProject.csproj"
echo "Entity Framework migration command completed for BlazorProject."
:Endpoint

