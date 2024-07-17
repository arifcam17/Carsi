using Carsi.Data;
using Carsi.Data.Abstract;
using Carsi.Data.Concrete;
using Carsi.Data.Concrete.Repositories;
using Carsi.Service.Abstract;
using Carsi.Service.Concrete;
using Carsi.Shared.HELPERS.Abstract;
using Carsi.Shared.HELPERS.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

 builder.Services.AddDbContext<CarsiDbContext>(options =>
 options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));




builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISepetRepository, SepetRepository>();
builder.Services.AddScoped<IItemRepository, ItemRepository>();



builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ISepetService, SepetService>();
builder.Services.AddScoped<IItemService, ItemService>();


builder.Services.AddScoped<IImageHelper, ImageHelper>();


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());  //BUNU KOPYA CEKTIM

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
