using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelBooking.Data;
using HotelBooking.Models;

namespace HotelBooking.Pages.Habitaciones
{
    public class IndexModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public IndexModel(HotelBookingContext context)
        {
            _context = context;
        }

        public IList<Habitacion> Habitaciones { get; set; }

        public async Task OnGetAsync()
        {
            Habitaciones = await _context.Habitaciones.ToListAsync();
        }
    }
}