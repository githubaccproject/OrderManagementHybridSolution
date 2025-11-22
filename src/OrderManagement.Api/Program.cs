
using Microsoft.EntityFrameworkCore;
using OrderManagement.Infrastructure;
using OrderManagement.Domain.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<OrderDbContext>(o =>
    o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
var app = builder.Build();
app.MapGet("/customers", async (OrderDbContext db) => await db.Customers.ToListAsync());
app.MapGet("/customers/{id}/orders", async (int id, OrderDbContext db) =>
    await db.Orders.Where(o => o.CustomerId == id).ToListAsync());
app.Run();
