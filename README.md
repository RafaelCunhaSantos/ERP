### English Version

# Project: .NET Core Application with Clean Code and Clean Architecture

This project is an application developed in .NET Core, following the principles of Clean Code, Clean Architecture, Domain-Driven Design (DDD), and SOLID principles. Additionally, we use Test-Driven Development (TDD) and unit tests to ensure code quality. The goal is to provide a solid foundation for developing scalable, maintainable, and testable applications.

## Project Structure

The project structure is organized according to Clean Architecture, separating responsibilities into different layers:

- **Domain**: Contains entities, aggregates, value objects, repository interfaces, and business rules.
- **Application**: Contains use cases and application services.
- **Infrastructure**: Contains repository implementations, external services, and configurations.
- **Presentation**: Contains the API, controllers, and user interfaces.

## Principles Used

- **Clean Code**: Clean, readable, and maintainable code with clear naming and following good programming practices.
- **Clean Architecture**: Separation of responsibilities, decoupling of modules, and framework independence.
- **Domain-Driven Design (DDD)**: Focus on the application's domain and business rules with rich and expressive modeling.
- **SOLID**: Object-oriented design principles to promote cohesion and reduce coupling.
- **Test-Driven Development (TDD)**: Writing tests before implementing the code.
- **Unit Testing**: Ensuring individual units of code work as expected.

## Technologies Used

- **.NET Core**: Framework for cross-platform application development.
- **Entity Framework Core**: ORM for database interaction.
- **AutoMapper**: Object-to-DTO mapping.
- **FluentValidation**: Fluent object validation.
- **MediatR**: Implementation of Mediator patterns for inter-layer communication.
- **xUnit**: Unit testing framework for .NET.
- **Moq**: Library for creating mocks in unit tests.

## Environment Setup

To set up the development environment, follow these steps:

1. Clone the repository:
    ```bash
    git clone https://github.com/user/project-name.git
    ```

2. Navigate to the project directory:
    ```bash
    cd project-name
    ```

3. Configure the environment variables and database connection string.

4. Run the Entity Framework migrations:
    ```bash
    dotnet ef database update
    ```

5. Start the application:
    ```bash
    dotnet run
    ```

## Running Tests

To run unit tests, use the command below:

```bash
dotnet test
