# backend

### Prerequisites

1. [.NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0#:~:text=May%2010%2C%202022-,Build%20apps%20%2D%20SDK,-Tooltip%3A%20Do%20you)

2. [SQL-Server](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16#:~:text=Free%20Download%20for%20SQL%20Server%20Management%20Studio%20(SSMS)%2018.12.1)

3. [SSMS](https://www.microsoft.com/en-in/sql-server/sql-server-downloads#:~:text=Download%20now-,Express,-SQL%20Server%202019)

### To Start 

1. make changes in *DefaultConnection* of `appsettings.json` 
    ```json
      "ConnectionStrings": {
        "DefaultConnection": "server=WINDOWS11\\SQLEXPRESS;database=Audit;trusted_connection=true;"
      },
    ```

2. For Database connection 

    ```powershell
    dotnet build
    ```

    ```powershell
    dotnet ef migrations add InitialCreate --context DataBaseContext --output-dir Migrations
    ```

    ```powershell
    dotnet ef database update
    ```

    For `AuthenticationException` use these commands
    ```powershell
    dotnet dev-certs https --clean
    dotnet dev-certs https --trust
    ```

    ```powershell
    dotnet run
    ```
