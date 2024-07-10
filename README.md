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

### Versão em Português

# Projeto: Aplicação .NET Core com Clean Code e Arquitetura Limpa

Este projeto é uma aplicação desenvolvida em .NET Core, seguindo os princípios de Clean Code, Arquitetura Limpa (Clean Architecture), Domain-Driven Design (DDD) e os princípios SOLID. Além disso, utilizamos Test-Driven Development (TDD) e testes unitários para garantir a qualidade do código. O objetivo é fornecer uma base sólida para o desenvolvimento de aplicações escaláveis, mantíveis e testáveis.

## Estrutura do Projeto

A estrutura do projeto está organizada conforme a Arquitetura Limpa, separando as responsabilidades em diferentes camadas:

- **Domain**: Contém as entidades, agregados, objetos de valor, interfaces de repositório e regras de negócio.
- **Application**: Contém os casos de uso (use cases) e serviços de aplicação.
- **Infrastructure**: Implementações de repositórios, serviços externos e configurações.
- **Presentation**: API, controladores e interfaces com o usuário.

## Princípios Utilizados

- **Clean Code**: Código limpo, legível e de fácil manutenção, com nomenclaturas claras e seguindo boas práticas de programação.
- **Arquitetura Limpa**: Separação de responsabilidades, desacoplamento de módulos e independência de frameworks.
- **Domain-Driven Design (DDD)**: Foco no domínio da aplicação e nas regras de negócio, com modelagem rica e expressiva.
- **SOLID**: Princípios de design orientados a objetos para promover a coesão e reduzir o acoplamento.
- **Test-Driven Development (TDD)**: Desenvolvimento orientado a testes, escrevendo testes antes da implementação do código.
- **Testes Unitários**: Garantia de que as unidades individuais do código funcionem conforme o esperado.

## Tecnologias Utilizadas

- **.NET Core**: Framework para desenvolvimento de aplicações multiplataforma.
- **Entity Framework Core**: ORM para interação com o banco de dados.
- **AutoMapper**: Mapeamento de objetos para DTOs.
- **FluentValidation**: Validação de objetos de forma fluente.
- **MediatR**: Implementação de padrões Mediator para comunicação entre camadas.
- **xUnit**: Framework de testes unitários para .NET.
- **Moq**: Biblioteca para criação de mocks em testes unitários.

## Configuração do Ambiente

Para configurar o ambiente de desenvolvimento, siga os passos abaixo:

1. Clone o repositório:
    ```bash
    git clone https://github.com/usuario/nome-do-projeto.git
    ```

2. Navegue até o diretório do projeto:
    ```bash
    cd nome-do-projeto
    ```

3. Configure as variáveis de ambiente e a string de conexão do banco de dados.

4. Execute as migrações do Entity Framework:
    ```bash
    dotnet ef database update
    ```

5. Inicie a aplicação:
    ```bash
    dotnet run
    ```

## Execução dos Testes

Para executar os testes unitários, utilize o comando abaixo:

```bash
dotnet test


To run unit tests, use the command below:

```bash
dotnet test
