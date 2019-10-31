using Microsoft.EntityFrameworkCore;

namespace PlayToy_3.Models
{
    public class JugueteriaContext: DbContext
    {
        public DbSet<Usuario> Usuarios {get;set;}

        public DbSet<Juguete> Juguetes {get;set;}

        public DbSet<Pedido> Pedidos{get;set;}

        public JugueteriaContext(DbContextOptions<JugueteriaContext> o): base(o){

        } 
    }
}