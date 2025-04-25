# Amadeus City Search API Template

Amadeus City Search API is a lightweight ASP.NET Core 8 web service that provides a simple interface to search for cities using the Amadeus API. This template is for a service that wraps the Amadeus City Search API and handles authentication, error handling, and response formatting.

Key features that are implemented in the accompanying blog post:
- Search for cities by keyword
- Input validation using FluentValidation
- Proper error handling and response formatting
- OAuth 2.0 token management for Amadeus API
- Dockerized for easy deployment
- Swagger UI for API documentation and testing

## Prerequisites

To start using this project, you'll need:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/products/docker-desktop) (optional, for containerized deployment)
- Amadeus API credentials (API Key and Secret)
    - Register at [Amadeus for Developers](https://developers.amadeus.com/) to obtain your credentials

## Installation Instructions

### Clone the repository

```bash
git clone https://github.com/ivankahl/amadeus-city-search.git
cd amadeus-city-search
```

### Restore dependencies

```bash
dotnet restore
```

### Next Steps

Please see the accompanying blog post for next steps.