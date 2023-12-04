using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalECommerce.Shared;

namespace ProyectoFinalECommerce.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<ProyectoFinalECommerce.Shared.TelefonosClientes> TelefonosClientes { get; set; } = default!;


        public DbSet<Productos> Productos { get; set; }
        public DbSet<Categorias> Categorias { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TelefonosClientes>().HasData(new List<TelefonosClientes>()
            {

                new TelefonosClientes(){
                    TipoTelId = 1, TipoTelefono ="Telefono Local"
                },

                new TelefonosClientes(){
                    TipoTelId = 2, TipoTelefono = "Celular"
                },

                new TelefonosClientes(){
                    TipoTelId = 3, TipoTelefono = "Trabajo"
                },

                new TelefonosClientes(){
                    TipoTelId = 4, TipoTelefono ="Persona Auxiliar"
                }
            });

            modelBuilder.Entity<Categorias>().HasData(new List<Categorias>()
            {
                    new Categorias
                    {
                        CategoriaId = 1,
                        Nombre = "Electrodomesticos",
                        Url ="electrodomesticos",
                        Icon = "camera-slr"
                    },
                    new Categorias
                    {
                        CategoriaId = 2,
                        Nombre = "Productos del Hogar",
                        Url ="productosDelHogar",
                        Icon = "camera-slr"
                    },
                    new Categorias
                    {
                        CategoriaId = 3,
                        Nombre = "Televisores",
                        Url ="televisores",
                        Icon = "camera-slr"
                    }
            });
        }
        
        



    }
}
