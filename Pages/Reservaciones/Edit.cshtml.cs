using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelBooking.Data;
using HotelBooking.Models;

namespace HotelBooking.Pages.Reservaciones
{
    public class EditModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public EditModel(HotelBookingContext context)
        {
            _context = context;
        }

        [BindProperty]
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

            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "NombreCompleto");
            ViewData["IdHabitacion"] = new SelectList(_context.Habitaciones, "IdHabitacion", "Numero");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Reservacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservacionExists(Reservacion.IdReservacion))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ReservacionExists(int id)
        {
            return _context.Reservaciones.Any(e => e.IdReservacion == id);
        }
    }
}