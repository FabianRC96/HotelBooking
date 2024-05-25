using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelBooking.Data;
using HotelBooking.Models;

namespace HotelBooking.Pages.TiposHabitacion
{
    public class IndexModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public IndexModel(HotelBookingContext context)
        {
            _context = context;
        }

        public IList<TipoHabitacion> TiposHabitacion { get; set; }

        public async Task OnGetAsync()
        {
            TiposHabitacion = await _context.TiposHabitacion.ToListAsync();
        }
    }
}