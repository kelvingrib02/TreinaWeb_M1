using Microsoft.EntityFrameworkCore;
using TWTodoList.EntityConfigs;
using TWTodoList.Models;

namespace TWTodoList.Contexts;

public class AppDbContex : DbContext
{
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=TWTodoList;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TodoEntityConfig());
    }
}