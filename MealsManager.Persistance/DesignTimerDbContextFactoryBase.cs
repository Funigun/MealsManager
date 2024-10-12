using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MealsManager.Persistance
{
    public abstract class DesignTimerDbContextFactoryBase<TContext> : IDesignTimeDbContextFactory<TContext> where TContext : DbContext
    {
        private const string ConnectionStringName = "MealsManager";
        private const string EnvironmentName = "ASPNETCORE_ENVIRONMENT";

        public TContext CreateDbContext(string[] args)
        {
            IConfigurationRoot config = CreateDbConfiguration();
            string connectionString = config.GetConnectionString(ConnectionStringName);

            DbContextOptionsBuilder<TContext> optionsBuilder = CreateDbOptions(connectionString);

            return CreateContextInstance(optionsBuilder.Options);
        }

        private static IConfigurationRoot CreateDbConfiguration()
        {
            string path = Directory.GetCurrentDirectory() + string.Format("{0}..{0}MealsManager", Path.DirectorySeparatorChar);

            return new ConfigurationBuilder()
                   .SetBasePath(path)
                   .AddJsonFile("appsettings.json")
                   .AddJsonFile("appsettings.Local.json", optional: true)
                   .AddJsonFile($"appsettings.{EnvironmentName}.json", optional: true)
                   .AddEnvironmentVariables()
                   .Build();
        }

        public static DbContextOptionsBuilder<TContext> CreateDbOptions(string? connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException($"Connection string {connectionString} is null or empty.", nameof(connectionString));
            }

            DbContextOptionsBuilder<TContext> optionsBuilder = new();
            optionsBuilder.UseSqlServer(connectionString);

            return optionsBuilder;
        }

        public abstract TContext CreateContextInstance(DbContextOptions<TContext> options);
    }
}
