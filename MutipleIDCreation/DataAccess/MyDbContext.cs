using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class MyDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=CGNPLAP429\\SQLEXPRESS;Database=MultiIDTestDB;Trusted_Connection=True;");
    }
}
