using assignement.data;
using Microsoft.EntityFrameworkCore;

namespace assignement.Models
{
    public class Db : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Enrolled> Enrolled { get; set; }
     
        }

    }
}
