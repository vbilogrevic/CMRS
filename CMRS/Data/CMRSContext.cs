using CMRS.Models;
using Microsoft.EntityFrameworkCore;

namespace CMRS.Data
{
    public class CMRSContext : DbContext
    {
        public CMRSContext(DbContextOptions<CMRSContext> options) : base(options) { }

        public DbSet<Medijator> Medijatori {  get; set; }
        public DbSet<Institucija> Institucije { get; set; }
    }
}
