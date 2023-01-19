using ApsNetCore6;
using ApsNetCore6.Models;
using ApsNetCore6.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;





var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var sqlConnection = new SqlConnectionStringBuilder();
builder.Services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.MapGet("/", () => "Hello World!");

app.MapGet("/customers", () =>
{
    return new List<SuppliersSampleModels>
    {
      new SuppliersSampleModels {SupplierID=1,City="Hyd",Country= "Ind"},
      new SuppliersSampleModels { SupplierID = 2, City = "BEng", Country = "Ind" }
    };
});


app.MapGet("api/categories", (ICategoriesRepository repo) =>
{
    var categories = repo.GetAll();
    return Results.Ok(categories);
});

app.MapGet("/suppliers", () =>
{
    return new List<SuppliersSampleModels>
    {
      new SuppliersSampleModels {SupplierID=1,City="Hyd",Country= "Ind"},
      new SuppliersSampleModels { SupplierID = 2, City = "BEng", Country = "Ind" }
    };
});



app.Run();