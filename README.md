## Devices API

REST API for retrieving Devices

### Requirements

- .NET 6 installed locally
- MSSQL

The frontend code is on the follwoing [link](https://github.com/nkalajdzic1/devices-web). The repository contains instructions
on how to setup the frontend, but before setting up the frontend, backend must be up and running.

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

### Architecture overview

Project architecture is the Clean 'Onion' architecture with few modifications:

- The layers are differently named (Web is for the Domain Layer, Infrastructure is for the DAL and Core is for the BLL)
- The business logic, data access logic and domain logic is not strictly separated in this architecture
  - Infrastructure has services (e.g. DeviceService) to handle the business logic and data access logic because there is no needin this particular use case to separate these two abstractions because then it is overengineering
  - No need for repositories because it would be overengineering
  - No need to separate the interfaces for each layer, they are in the DevicesApi.Core
- The architecture is also using Request-Response pattern to handle data transfer from the domain to the 'lower layer'
- The API is 'REST API oriented' - it is a minimalistic api with http methods that may not be used by the client

### Todos to improve the api

- Setup proper versioning - the server is now hardcoded for version v1
- Setup logger more strategically - log what is needed, not just controller and service method calls and exceptions
- Add Dockerfile and .yml build file
- Add CI/CD and proper branch strategy (not just master branch)
- Add unit tests
- Add postman collection
- Add Cancellation token to enable request canceling
