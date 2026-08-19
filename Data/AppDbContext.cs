using AulaBackend_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AulaBackend_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Fruta> Frutas { get; set; }
    }
}