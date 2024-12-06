using CrudNet8MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet8MVC.Data
{
    public class ApplicationDbContext : DbContext
    {

        // Agregar los modelos aqui. Cada modelo corresponde a una tabla de la bd
        public DbSet<Contacto> Contactos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)  : base(options)
        {
            
        }
    }
}
