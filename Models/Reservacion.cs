using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Models
{
    public class Reservacion
    {
        [Key]
        public int IdReservacion { get; set; } // Primary Key

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; } // Forean key
        public Cliente Cliente { get; set; }

        [ForeignKey("Habitacion")]
        public int IdHabitacion { get; set; } // Forean key
        public Habitacion Habitacion { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaEntrada { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }

        [DataType(DataType.Currency)]
        public double TotalPago { get; set; }
    }
}
