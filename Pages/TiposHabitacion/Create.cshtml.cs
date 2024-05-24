using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using HotelBooking.Data;
using HotelBooking.Models;

namespace HotelBooking.Pages.TiposHabitacion
{
    public class CreateModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public CreateModel(HotelBookingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TipoHabitacion TipoHabitacion { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TiposHabitacion.Add(TipoHabitacion);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}