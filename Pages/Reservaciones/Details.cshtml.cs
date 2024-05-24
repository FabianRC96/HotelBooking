using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelBooking.Data;
using HotelBooking.Models;

namespace HotelBooking.Pages.Reservaciones
{
    public class DetailsModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public DetailsModel(HotelBookingContext context)
        {
            _context = context;
        }

        public Reservacion Reservacion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Reservacion = await _context.Reservaciones
                .Include(r => r.Cliente)
                .Include(r => r.Habitacion)
                .FirstOrDefaultAsync(m => m.IdReservacion == id);

            if (Reservacion == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}