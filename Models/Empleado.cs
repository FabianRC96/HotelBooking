using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class Empleado
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpleado { get; set; } // Primary key

        [Required]
        [StringLength(50)]
        public string NombreEmpleado { get; set; }

        [Required]
        [StringLength(50)]
        public string Posicion { get; set; }

        [Required]
        public int IdUsuario { get; set; } // Forean Key
    }
}
