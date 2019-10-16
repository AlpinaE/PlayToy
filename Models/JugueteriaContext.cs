using Microsoft.EntityFrameworkCore;

namespace PlayToy_3.Models
{
    public class JugueteriaContext: DbContext
    {
        public DbSet<Usuario> usuarios {get;set;}

        public JugueteriaContext(DbContextOptions<JugueteriaContext> o): base(o){

        } 
    }
}