using HotelBooking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HotelBooking.Data
{
    public class HotelBookingContext : DbContext
    {
        public HotelBookingContext(DbContextOptions<HotelBookingContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<TipoHabitacion> TiposHabitacion { get; set; }
        public DbSet<Reservacion> Reservaciones { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().HasKey(c => c.IdCliente);
            modelBuilder.Entity<Habitacion>().HasKey(h => h.IdHabitacion);
            modelBuilder.Entity<TipoHabitacion>().HasKey(t => t.IdTipo);
            modelBuilder.Entity<Reservacion>().HasKey(r => r.IdReservacion);
            modelBuilder.Entity<Empleado>().HasKey(e => e.IdEmpleado);
        }
    }
}
