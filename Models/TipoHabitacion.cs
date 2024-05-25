using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class TipoHabitacion
    {
        [Key]
        public int IdTipo { get; set; } // Primary key
        public string Descripcion { get; set; }
        public int Capacidad { get; set; }
    }
}
