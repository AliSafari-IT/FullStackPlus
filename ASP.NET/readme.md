# Blogging Platform: A Simple ASP.NET Core Blogging Platform with Razor and Blazor

RazorBlog is a basic blogging platform built with ASP.NET Core Razor Pages. It's designed as a practice project for those looking to get hands-on experience with full-stack development using Razor Pages. This platform allows users to create, read, update, and delete blog posts, with added functionalities for user authentication and comments.

## Features

- **User Authentication**: Secure registration and login functionality using ASP.NET Core Identity.
- **Blog Post Management**: Create, read, update, and delete blog posts. Posts include title, content, author, and date.
- **Database Integration**: Utilizes Entity Framework Core for data handling and CRUD operations with a SQL or SQLite database.
- **Responsive Design**: Front-end layout and design using Bootstrap or similar CSS frameworks.
- **Comments Feature**: Allow users to comment on posts and authors to manage comments on their posts.

## Getting Started

### Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0) or later.
- A text editor or IDE (Preferably [Visual Studio](https://visualstudio.microsoft.com/)).

### Installation

1. Clone the repository or download the source code.
2. Open the solution in Visual Studio or your preferred editor.
3. Restore the required NuGet packages.
4. Ensure the connection strings in `appsettings.json` are set up for your database.
5. Run the application.

## Development Setup

1. **User Authentication**: Implemented with ASP.NET Core Identity. Customization in the Identity UI for registration and login.
    -   Implement user registration and login functionality.
    -   Allow only authenticated users to create, edit, or delete posts.
2. **Database Setup**: Define models and DbContext. Use EF Core migrations to create and update the database schema.
3. **Razor Pages Development**: Create Razor Pages for each feature in the `Pages` directory.
4. **Styling**: Use Bootstrap for CSS. Custom CSS can be added in the `wwwroot` directory.

## Testing

- Test CRUD operations on blog posts.
- Validate user authentication workflows.
- Responsive design checks on different devices and browsers.

## Deployment

- The application can be deployed to any hosting provider that supports ASP.NET Core applications. Azure is a recommended choice for cloud deployment.

## Contributing

Contributions to RazorBlog are welcome. Feel free to fork the repository and submit pull requests.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.