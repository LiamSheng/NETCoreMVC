using Microsoft.EntityFrameworkCore;
using NETCoreMVC.Models;

namespace NETCoreMVC.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Category> Categories { get; set; } // add "Category" table.
}