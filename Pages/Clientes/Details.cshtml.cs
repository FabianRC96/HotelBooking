using HotelBooking.Data;
using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Pages.Clientes
{
    public class DetailsModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public DetailsModel(HotelBookingContext context)
        {
            _context = context;
        }

        public Cliente Cliente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cliente = await _context.Clientes.FirstOrDefaultAsync(m => m.IdCliente == id);

            if (Cliente == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
