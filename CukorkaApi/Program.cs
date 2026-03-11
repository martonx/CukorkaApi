using CukorkaApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Ez a tesztekben használhatósághoz kell, hogy a teszt framework elérje az endpointokat
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<SugarDbContext>(options =>
  options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Cukorka;Trusted_Connection=True;MultipleActiveResultSets=true"));

var app = builder.Build();

app.MapGet("/getall", (SugarDbContext dbContext) => dbContext.Products.ToList());

app.MapGet("/get/{id:int}", (SugarDbContext dbContext, int id) => dbContext.Products.Single(p => p.Id == id));

app.MapPost("/add", (SugarDbContext dbContext, Product product) =>
{
    dbContext.Products.Add(product);
    dbContext.SaveChanges();
});

//TODO: implement update and delete and reports

app.Run();

//Ez a tesztekben használhatósághoz kell, hogy publikusan elérhetõ legyen a Program osztály
public partial class Program;
