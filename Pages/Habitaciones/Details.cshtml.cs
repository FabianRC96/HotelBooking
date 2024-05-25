using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelBooking.Data;
using HotelBooking.Models;

namespace HotelBooking.Pages.Habitaciones
{
    public class DetailsModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public DetailsModel(HotelBookingContext context)
        {
            _context = context;
        }

        public Habitacion Habitacion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Habitacion = await _context.Habitaciones.FirstOrDefaultAsync(m => m.IdHabitacion == id);

            if (Habitacion == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}