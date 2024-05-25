using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using HotelBooking.Data;
using HotelBooking.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace HotelBooking.Pages.Reservaciones
{
    public class CreateModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public CreateModel(HotelBookingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes.Select(c => new
            {
                IdCliente = c.IdCliente,
                NombreCompleto = c.Nombre + " " + c.Apellido
            }), "IdCliente", "NombreCompleto");

            ViewData["IdHabitacion"] = new SelectList(_context.Habitaciones, "IdHabitacion", "Numero");

            return Page();
        }

        [BindProperty]
        public Reservacion Reservacion { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
             

            _context.Reservaciones.Add(Reservacion);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}