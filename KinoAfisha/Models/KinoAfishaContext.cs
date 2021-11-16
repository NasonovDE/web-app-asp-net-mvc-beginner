using System.Data.Entity;

namespace KinoAfisha.Models
{
    public class KinoAfishaContext : DbContext
    {
        public DbSet<Kino> Kinos { get; set; }
        public KinoAfishaContext() : base("KinoAfishaEntity")
        { }
    }
}