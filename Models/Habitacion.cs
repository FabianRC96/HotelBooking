namespace HotelBooking.Models
{
    public class Habitacion
    {
        public int IdHabitacion { get; set; } // Primary key
        public int Numero { get; set; }
        public string Piso { get; set; }
        public double Precio { get; set; }
        public int IdTipo { get; set; } // Forean key
    }
}
