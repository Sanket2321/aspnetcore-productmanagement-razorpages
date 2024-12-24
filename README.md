# ASP.NET Core CRUD Application

This project is a simple CRUD (Create, Read, Update, Delete) application built with ASP.NET Core Razor Pages. It demonstrates basic database connection, entity management, and UI integration using Razor Pages and Bootstrap.

---

## **Features**
- Add, edit, view, and delete products.
- Responsive UI with Bootstrap.
- Database connection using Entity Framework Core.
- Razor Pages for building the UI.

---

## **Technologies Used**
- **ASP.NET Core** (Razor Pages)
- **Entity Framework Core** for database interaction
- **SQL Server** as the database
- **Bootstrap** for styling
- **Git** for version control

---

## **Getting Started**

### **Prerequisites**
- .NET SDK (download from [here](https://dotnet.microsoft.com/download))
- Visual Studio or any code editor with ASP.NET Core support
- SQL Server installed locally or accessible remotely
- Git installed

### **Setting Up the Project**
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repository.git
   cd your-repository
   ```

2. Open the project in Visual Studio.

3. Restore the NuGet packages:
   ```bash
   dotnet restore
   ```

4. Update the `appsettings.json` file with your SQL Server connection string:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=your-server-name;Database=your-database-name;Trusted_Connection=True;"
   }
   ```
   - Replace `your-server-name` with your SQL Server instance.
   - Replace `your-database-name` with the name of your database.

5. Apply migrations to create the database schema:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

6. Run the application:
   ```bash
   dotnet run
   ```

7. Open the application in your browser at `https://localhost:5001` (or the port specified in the terminal).

---

## **Learning Resources**

### **ASP.NET Core**
- [Official Documentation](https://learn.microsoft.com/en-us/aspnet/core/)
- [Razor Pages Tutorial](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/)

### **Entity Framework Core**
- [EF Core Documentation](https://learn.microsoft.com/en-us/ef/core/)
- [Getting Started with EF Core](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app)

### **SQL Server**
- [SQL Server Basics](https://learn.microsoft.com/en-us/sql/sql-server/)

---

## **Folder Structure**
```
CRUDRazorPages
│
├── Pages
│   ├── ProductMaster
│   │   ├── Index.cshtml  (List all products)
│   │   ├── Create.cshtml (Add a new product)
│   │   ├── Edit.cshtml   (Edit product details)
│   │   ├── Details.cshtml (View product details)
│   │   ├── Delete.cshtml (Delete a product)
│
├── Models
│   └── Product.cs       (Defines the Product entity)
│
├── Data
│   └── ApplicationDbContext.cs (Database context for EF Core)
│
├── wwwroot
│   └── css              (Contains Bootstrap and custom styles)
│
├── appsettings.json     (Configuration for the application)
└── Program.cs           (Application entry point)
```

---

## **Future Improvements**
- Add user authentication and authorization.
- Enhance UI with more Bootstrap components.
- Implement client-side validation.

---

## **Contributing**
Feel free to fork this repository, make changes, and create a pull request. Contributions are always welcome!

---

## **License**
This project is licensed under the MIT License. See the LICENSE file for details.
