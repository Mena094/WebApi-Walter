using Microsoft.EntityFrameworkCore;
using WebApi_WalterMena.Models;

namespace WebApi_WalterMena.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Estudiante> Estudiantes { get; set;}


    }
}
