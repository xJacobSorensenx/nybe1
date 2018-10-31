using Microsoft.EntityFrameworkCore;
using nybe1.Models;

namespace nybe1.Services
{
    public class MinDBContext : DbContext
    {
        public MinDBContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Kunde> DBSKunder { get; set; }
    }
}