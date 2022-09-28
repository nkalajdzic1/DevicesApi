## Devices API

REST API for retrieving Devices

### Requirements

.NET 6 installed locally
MSSQL

### Setup

1. in DevicesApi.Infrastructure run 'dotnet ef database update' to create the 'devices' database in your MSSQL instance.
2. Execute 'dotnet run' inside the DevicesApi.Web or run the solution from Visual Studio.
   If you choose to run the solution from Visual Studio, you need to set DevicesApi.Web as the Startup project.
   This needs to be done because DevicesApi.Core and DevicesApi.Infrastructure are Class Libraries and the DevicesApi.Web
   is the 'solution'.

- Server is now running on port [https://localhost:5000](https://localhost:5000)
- Swagger is now on url [https://localhost:5000/swagger/index.html](https://localhost:5000/swagger/index.html)

### Templates

Used the following template:
[Nadir.Kalajdzic.ASP.NET.Core.Web.API](https://www.nuget.org/packages/Nadir.Kalajdzic.ASP.NET.Core.Web.API)
(updated version of [Nadir.Kalajdzic.NETCoreWebApi.Template](https://www.nuget.org/packages/Nadir.Kalajdzic.NETCoreWebApi.Template))
