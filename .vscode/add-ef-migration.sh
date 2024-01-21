#!/bin/bash

read -p "Enter Migration Name: " inputName

if [ -z "$inputName" ]; then
    echo "No migration name provided. Entity Framework migration command skipped."
    exit 0
fi

dotnet ef migrations add "$inputName" --project "/path/to/your/RazorProject.csproj"

echo "Entity Framework migration command completed."
