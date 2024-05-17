namespace HotelBooking.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }  // Primary key
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
    }
}
