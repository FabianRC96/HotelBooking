using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelBooking.Data;
using HotelBooking.Models;

namespace HotelBooking.Pages.Reservaciones
{
    public class IndexModel : PageModel
   {
        private readonly HotelBookingContext _context;

        public IndexModel(HotelBookingContext context)
        {
            _context = context;
        }

        public IList<Reservacion> Reservacion { get;set; }

        public async Task OnGetAsync()
        {
            Reservacion = await _context.Reservaciones
                .Include(r => r.Cliente)
                .Include(r => r.Habitacion)
                .ToListAsync();
        }
    }
}