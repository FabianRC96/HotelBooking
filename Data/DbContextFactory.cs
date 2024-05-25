using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;    

namespace HotelBooking.Data
{
    public class HotelBookingContextFactory : IDesignTimeDbContextFactory<HotelBookingContext>
    {
        public HotelBookingContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HotelBookingContext>();

            // Construir configuración
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("HotelBookingDB");

            optionsBuilder.UseSqlServer(connectionString);

            return new HotelBookingContext(optionsBuilder.Options);
        }
    }
}