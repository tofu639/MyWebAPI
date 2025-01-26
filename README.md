
# MyWebAPI Project

This is a simple API built using .NET 6 that demonstrates the repository pattern and how to set up basic CRUD operations for managing products. The API interacts with an in-memory database for simplicity.

## Features
- **CRUD operations** for products
- Uses **Repository pattern** for data access
- **In-memory database** for testing and development purposes
- **No external dependencies** (No database required for basic usage)

## Getting Started

### Prerequisites
Ensure that you have the following installed:
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- A code editor (such as [Visual Studio Code](https://code.visualstudio.com/))

### Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/MyWebAPI.git
   cd MyWebAPI
   ```

2. **Install dependencies** (if necessary):
   ```bash
   dotnet restore
   ```

3. **Run the project**:
   ```bash
   dotnet run
   ```

4. The API will be running at `http://localhost:5000`.

## API Endpoints

### 1. Get All Products
- **Endpoint**: `GET /api/products`
- **Description**: Retrieve a list of all products.
- **Response**: 
  ```json
  [
    {
      "id": 1,
      "name": "Product 1",
      "price": 100.0
    },
    {
      "id": 2,
      "name": "Product 2",
      "price": 200.0
    }
  ]
  ```

### 2. Get a Product by ID
- **Endpoint**: `GET /api/products/{id}`
- **Description**: Retrieve a single product by its ID.
- **Response**:
  ```json
  {
    "id": 1,
    "name": "Product 1",
    "price": 100.0
  }
  ```

### 3. Add a New Product
- **Endpoint**: `POST /api/products`
- **Description**: Create a new product.
- **Request Body**:
  ```json
  {
    "name": "New Product",
    "price": 150.0
  }
  ```
- **Response**:
  ```json
  {
    "id": 3,
    "name": "New Product",
    "price": 150.0
  }
  ```

### 4. Update a Product
- **Endpoint**: `PUT /api/products/{id}`
- **Description**: Update an existing product by its ID.
- **Request Body**:
  ```json
  {
    "id": 1,
    "name": "Updated Product",
    "price": 120.0
  }
  ```
- **Response**:
  ```json
  {
    "id": 1,
    "name": "Updated Product",
    "price": 120.0
  }
  ```

### 5. Delete a Product
- **Endpoint**: `DELETE /api/products/{id}`
- **Description**: Delete a product by its ID.
- **Response**: `204 No Content` (no content)

## Running Tests

You can run the tests for this project with the following command:

```bash
dotnet test
```