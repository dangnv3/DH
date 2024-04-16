using Microsoft.EntityFrameworkCore;

namespace DH.Models
{
    public class DataDbcontext: DbContext
    {
        public DataDbcontext(DbContextOptions<DataDbcontext> options) : base(options)
        {

        }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
