namespace HotelBooking.Models
{
    public class Reservacion
    {
        public int IdReservacion { get; set; } // Primary Key
        public int IdCliente { get; set; } // Forean key
        public int IdHabitacion { get; set; } // Forean key
        public string FechaEntrada { get; set; }
        public string FechaSalida { get; set; }
        public double TotalPago { get; set; }
    }
}
