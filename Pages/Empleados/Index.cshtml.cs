using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HotelBooking.Models;
using HotelBooking.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Pages.Empleados
{
    public class IndexModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public IndexModel(HotelBookingContext context)
        {
            _context = context;
        }

        public IList<Empleado> Empleados { get; set; }

        public async Task OnGetAsync()
        {
            Empleados = await _context.Empleados.ToListAsync();
        }
    }
}