# Read Me
This readme file contains instructions on setting up the project and running the solution.

## 1. Setting Up the Database
### Importing the .bacpac File to MS SQL Server
1. Locate the .bacpac file **(StudentGradingSystemDb.bacpac)** provided with the project.
2. Open Microsoft SQL Server Management Studio.
3. Connect to your SQL Server instance.
4. Right-click on Databases in the Object Explorer.
5. Select Import Data-tier Application... from the context menu.
6. Follow the wizard, selecting the .bacpac file when prompted.
7. Complete the import process by following the on-screen instructions.
### Changing appsettings.json
1. Navigate to the project directory.
2. Open the appsettings.json file located in the project.
3. Find the "ConnectionStrings" section.
4. Modify the connection string to match your SQL Server settings if necessary.
Example:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Initial Catalog=YOUR_DATABASE;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;TrustServerCertificate=True;"
}
```
## 2. Running the Solution
1. Open the solution file in Visual Studio or your preferred IDE.
2. Build the solution to restore dependencies.
3. Set the startup project if necessary.
4. Press F5 or click on the "Start" button to run the solution.

That's it! You should now have the database set up and the solution running successfully. 
