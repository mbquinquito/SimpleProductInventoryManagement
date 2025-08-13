# Product Inventory Management

## Prerequisites
- .NET 8 SDK
- MySQL Server 
- Visual Studio 2022 / VS Code
- Git
- (Optional) Postman for API testing

## Setup
1. Clone the repository:
	- https://github.com/mbquinquito/SimpleProductInventoryManagement.git
2. Load all projects and restore NuGet packages
3. Set up the database
	- Create a MySQL database (example: product_inventory_db)
	- Open appsettings.json in the API project and update connection string
	- Apply migrations (Use API as startup project)
		- Products Table and data seeding (Default project in Package Manager Console: Persistence)
			- add-migration InitProduct -Context ProductDatabaseContext
			- update-database -Context ProductDatabaseContext
		- Identity Table and data seeding (Default project in Package Manager Console: Identity)
			- add-migration InitIdentity -Context ProductEntityIdentityDbContext
			- update-database -Context ProductEntityIdentityDbContext
4. Run the application
	- Set up the BlazorUI and API as startup project.
	- Run
	- Login with:
		- Admin: admin@localhost.com / P@ssword1
		- User: user@localhost.com / P@ssword1

## API Endpoints

### Auth
- POST `/api/auth/login` – Authenticate user, returns JWT

### Products
- GET `/api/products` – Get all products
- GET `/api/products/{id}` – Get product by ID
- POST `/api/products` – Create new product (Admin only)
- PUT `/api/products/{id}` – Update product (Admin only)
- DELETE `/api/products/{id}` – Delete product (Admin only)