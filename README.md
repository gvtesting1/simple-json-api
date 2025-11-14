# Simple JSON API

This project is a simple .NET Core API that serves a JSON file through a single endpoint.

## Getting Started

### Prerequisites

- .NET Core SDK (version 3.1 or later)
- A code editor (e.g., Visual Studio Code)

### Installation

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd simple-json-api/src/SimpleJsonApi
   ```

3. Restore the dependencies:
   ```
   dotnet restore
   ```

### Running the API

To run the API, use the following command:
```
dotnet run
```

The API will be available at `http://localhost:5000`.

### Endpoint

- **GET /json**: Retrieves the contents of the `sample.json` file.

### Sample JSON Data

The JSON data served by the API can be found in the `Data/sample.json` file.

### Testing

To run the tests, navigate to the test project directory:
```
cd ../../tests/SimpleJsonApi.Tests
```
And run:
```
dotnet test
```

### License

This project is licensed under the MIT License.