using MDLTestMatsapura._Internal.Implementations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
 
internal class SampleContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
{
    public ApplicationContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
 
        ConfigurationBuilder builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("appsettings.json");
        IConfigurationRoot config = builder.Build();
 
        string connectionString = config.GetConnectionString("DefaultConnection");
        optionsBuilder.UseNpgsql(connectionString);
        return new ApplicationContext(optionsBuilder.Options);
    }
}