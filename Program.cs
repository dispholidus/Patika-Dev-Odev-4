using BookStoreApi.DbOperations;
using BookStoreApi.Models;
using BookStoreApi.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BookStoreDbContext>(options => options.UseInMemoryDatabase(databaseName: "BookStoreDb"));
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<BookModelValidator, BookModelValidator>();
builder.Services.AddScoped<CreateBookModelValidator, CreateBookModelValidator>();
builder.Services.AddScoped<UpdateBookModelValidator, UpdateBookModelValidator>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

DataGenerator.SeedData(app);
app.Run();
