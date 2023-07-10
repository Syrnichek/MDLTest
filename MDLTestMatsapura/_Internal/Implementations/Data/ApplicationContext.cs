using MDLTestMatsapura._Internal.Models;
using Microsoft.EntityFrameworkCore;

namespace MDLTestMatsapura._Internal.Implementations.Data
{
    internal class ApplicationContext
    {
        public DbSet<MailModel> Mails { get; set; }
    }
}