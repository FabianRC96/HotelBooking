using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelBooking.Data;
using HotelBooking.Models;

namespace HotelBooking.Pages.TiposHabitacion
{
    public class DetailsModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public DetailsModel(HotelBookingContext context)
        {
            _context = context;
        }

        public TipoHabitacion TipoHabitacion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TipoHabitacion = await _context.TiposHabitacion.FirstOrDefaultAsync(m => m.IdTipo == id);

            if (TipoHabitacion == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}