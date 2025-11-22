
using Microsoft.EntityFrameworkCore;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Infrastructure;
public class OrderDbContext : DbContext {
    public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) {}
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Order> Orders => Set<Order>();
}
