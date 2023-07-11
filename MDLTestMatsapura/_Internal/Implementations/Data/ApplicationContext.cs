using MDLTestMatsapura._Internal.Models;
using Microsoft.EntityFrameworkCore;

namespace MDLTestMatsapura._Internal.Implementations.Data
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<MailModel> Mails { get; set; }
        
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MDLTestDb;Username=postgres;Password=1111");
        }
    }
}