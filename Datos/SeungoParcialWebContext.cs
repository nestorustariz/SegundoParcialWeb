using Microsoft.EntityFrameworkCore;
using Entity;
 
namespace Datos
{
    public class SeungoParcialWebContext: DbContext
    {
        public SeungoParcialWebContext(DbContextOptions options):base(options)
        {
            
        }
        
        public DbSet<Persona>personas{get;set;}

        public DbSet<Vacunacions>vacunas{get;set;}
    }
}

