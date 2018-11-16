using Microsoft.EntityFrameworkCore;
using PoodleTrimmers.Domain;

namespace PoodleTrimmers
{
    public class PoodleTrimmersDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Stylist> Stylists { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1;DataBase=PoodleTrimmers;user id=SA;pwd=Ryan2134!;");
        }
    }
}