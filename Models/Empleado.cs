namespace HotelBooking.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; } // Primary key
        public string NombreEmpleado { get; set; }
        public string Posicion { get; set; }
        public int IdUsuario { get; set; } // Forean Key
    }
}
