using DevicesApi.Web.Extensions;
using DevicesApi.Web.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// add web api controllers and the healthcheck
services.AddHealthChecks();
// add controllers, the mvc builder instance will be needed for other configuration
var mvcBuilder = services.AddControllers().AddNewtonsoftJson();

// enable lowercase routes for endpoints
services.AddRouting(options => options.LowercaseUrls = true);
services.AddEndpointsApiExplorer();

// add http context accesor
services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

#region Custom Configuration for services - this must be before the application build

DatabaseContext.AddDbContexts(ref services);
Swagger.AddSwaggerConfig(ref services);
Scoped.AddScopedConfig(ref services);
JsonOptions.AddJsonOptions(ref mvcBuilder);
services.AddAutoMapper(typeof(AutoMapperProfile));

#endregion 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Devices API"));
}

app.UseHttpsRedirection();

#region Custom Configuration for app middlewares, cors and etc.

app.UseMiddleware<ExceptionMiddleware>();
Cors.AddCors(app);

#endregion

app.MapControllers();

app.Run();
