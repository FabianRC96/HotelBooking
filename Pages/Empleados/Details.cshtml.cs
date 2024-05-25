using HotelBooking.Data;
using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HotelBooking.Pages.Empleados
{
    public class DetailModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public DetailModel(HotelBookingContext context)
        {
            _context = context;
        }

        public Empleado Empleado { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Empleado = await _context.Empleados.FirstOrDefaultAsync(m => m.IdEmpleado == id);

            if (Empleado == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
