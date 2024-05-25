using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelBooking.Data;
using HotelBooking.Models;

namespace HotelBooking.Pages.Habitaciones
{
    public class DeleteModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public DeleteModel(HotelBookingContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Habitacion = await _context.Habitaciones.FindAsync(id);

            if (Habitacion != null)
            {
                _context.Habitaciones.Remove(Habitacion);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}