using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelBooking.Data;
using HotelBooking.Models;

namespace HotelBooking.Pages.TiposHabitacion
{
    public class DeleteModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public DeleteModel(HotelBookingContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TipoHabitacion = await _context.TiposHabitacion.FindAsync(id);

            if (TipoHabitacion != null)
            {
                _context.TiposHabitacion.Remove(TipoHabitacion);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}