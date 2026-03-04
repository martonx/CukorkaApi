using CukorkaApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SugarDbContext>(options =>
  options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Cukorka;Trusted_Connection=True;MultipleActiveResultSets=true"));

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/getall", (SugarDbContext dbContext) => dbContext.Products.ToList());

app.MapGet("/get/{id:int}", (SugarDbContext dbContext, int id) => dbContext.Products.Single(p => p.Id == id));

app.MapPost("/add", (SugarDbContext dbContext, Product product) =>
{
    dbContext.Products.Add(product);
    dbContext.SaveChanges();
});

//TODO: implement update and delete and reports

app.Run();
