<<<<<<< HEAD
=======
using HotelBooking.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

>>>>>>> test
namespace HotelBooking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
<<<<<<< HEAD
=======
            builder.Services.AddDbContext<HotelBookingContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("HotelBookingDB")));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                 .AddEntityFrameworkStores<HotelBookingContext>();
>>>>>>> test

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
<<<<<<< HEAD

=======
            app.UseAuthentication();
>>>>>>> test
            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
