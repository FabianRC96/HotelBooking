using HotelBooking.Data;
using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public IndexModel(HotelBookingContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get; set; }

        public async Task OnGetAsync()
        {
            Cliente = await _context.Clientes.ToListAsync();
        }
    }
}
