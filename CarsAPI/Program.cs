using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cars API", Description = "Receive cars info!", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cars API V1");
});

app.MapGet("/cars/{id}", (int id) => CarObjects.Car.GetCar(id).PrintCar());
app.MapGet("/cars/CompareExpenses100km/{first}&&{second}", (int first, int second) => CarsInherit.Functions.GetComparisonExpense100km(first, second));
app.MapGet("/cars/CompareTaxiRegime5days/{first}&&{second}", (int first, int second) => CarsInherit.Functions.GetComparisonTaxiRegime(first, second));
app.MapGet("/cars/EqualExpense30km/{first}&&{second}", (int first, int second) => CarsInherit.Functions.EqualExpense30km(first, second));

app.Run();