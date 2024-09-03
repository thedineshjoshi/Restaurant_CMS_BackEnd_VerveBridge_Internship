# Restaurant Management System - CMS Backend

## Overview

This project is a backend service for a Restaurant Management System CMS (Content Management System) built using ASP.NET Core. The backend provides APIs for managing various entities such as Menus, Reservations, Team Members, Testimonials, and more. It includes role-based authentication and authorization, allowing different users (e.g., Admin, Content Manager, Menu Manager) to manage the restaurant's content.

## Features

- **Role-Based Authentication**: Secure APIs with JWT authentication and role-based access control.
- **Content Management**: APIs for managing restaurant menus, reservations, team members, testimonials, and other content.
- **Admin Dashboard**: Provides an admin interface for managing all aspects of the restaurant's content.
- **API Documentation**: Swagger/OpenAPI documentation for easy API consumption.

## Technologies Used

- **ASP.NET Core**: Backend framework.
- **Entity Framework Core**: ORM for database access.
- **MediatR**: Implementation of CQRS (Command Query Responsibility Segregation) pattern.
- **SQL Server**: Database for storing restaurant data.
- **JWT Authentication**: For secure API access.
- **AutoMapper**: For object-object mapping.
- **FluentValidation**: For validating incoming requests.

## Prerequisites

Before running this project, ensure you have the following installed:

- **.NET SDK**: [.NET 8.0](https://dotnet.microsoft.com/download)
- **SQL Server**: Local or remote SQL Server instance
- **Visual Studio or VS Code**: For development and debugging
- **Postman**: (Optional) For API testing

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/your-username/restaurant-cms-backend.git
cd restaurant-cms-backend
