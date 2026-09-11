using Microsoft.EntityFrameworkCore;
using VaultContactos.Models;

namespace VaultContactos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contacto> Contactos { get; set; } = null!;
    }
}