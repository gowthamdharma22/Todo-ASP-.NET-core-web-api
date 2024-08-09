# Todo API

This is a Todo API built with ASP.NET Core Web API. It supports user authentication using JWT and provides endpoints to manage todo items for authenticated users.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Developed by](#developed-by)

## Features

- User registration and authentication
- JWT-based authentication
- CRUD operations for todo items
- User-specific todos
- Swagger API documentation

## Technologies Used

- ASP.NET Core
- Entity Framework Core
- SQLite
- JWT Authentication
- Swagger for API documentation

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQLite](https://www.sqlite.org/download.html)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/todo-api.git
   cd todo-api

2. Restore the dependencies:
   
    ```bash
    dotnet restore

3. Update the `appsettings.json` file with your configuration

   ```bash
     {
    "ConnectionStrings": {
    "DefaultConnection": "Data Source=todo.db"
    }
    }

4. Apply the database migrations:

   ```bash
   dotnet ef database update

5. Run the application:

   ```bash
   dotnet run

## Developed By

Developed by [Gowtham Dharma]([https://www.linkedin.com/in/gowtham-dharma-e-0a463a232/])


This `README.md` file covers the project overview, setup instructions, API endpoints, and other useful information for developers working with your Todo API. Feel free to adjust any sections as needed to better fit your project specifics.
