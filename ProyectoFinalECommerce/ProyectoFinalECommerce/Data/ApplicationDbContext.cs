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
        public DbSet<Carrito> Carrito { get; set; } = default!;

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
        }
        
        



    }
}
