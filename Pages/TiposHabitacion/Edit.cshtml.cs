using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelBooking.Data;
using HotelBooking.Models;

namespace HotelBooking.Pages.TiposHabitacion
{
    public class EditModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public EditModel(HotelBookingContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Cargar la entidad original desde la base de datos
            var tipoHabitacionToUpdate = await _context.TiposHabitacion.FindAsync(TipoHabitacion.IdTipo);

            if (tipoHabitacionToUpdate == null)
            {
                return NotFound();
            }

            // Actualizar las propiedades con los valores vinculados
            tipoHabitacionToUpdate.Descripcion = TipoHabitacion.Descripcion;
            tipoHabitacionToUpdate.Capacidad = TipoHabitacion.Capacidad;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoHabitacionExists(TipoHabitacion.IdTipo))
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

        private bool TipoHabitacionExists(int id)
        {
            return _context.TiposHabitacion.Any(e => e.IdTipo == id);
        }
    }
}