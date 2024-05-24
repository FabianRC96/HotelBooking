using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using HotelBooking.Data;
using HotelBooking.Models;

namespace HotelBooking.Pages.Habitaciones
{
    public class CreateModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public CreateModel(HotelBookingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Habitacion Habitacion { get; set; }

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

            _context.Habitaciones.Add(Habitacion);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}