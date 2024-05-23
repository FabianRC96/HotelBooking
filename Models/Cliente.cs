using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }  // Primary key

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public int Telefono { get; set; }
    }
}
