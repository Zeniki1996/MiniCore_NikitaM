
using Microsoft.EntityFrameworkCore;
using MiniCore.Data;

namespace MiniCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }
        public DbSet<MiniCore.Data.Cliente> Cliente { get; set; }
        public DbSet<MiniCore.Data.Contratos> Contratos { get; set; }
    }
}