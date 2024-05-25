using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HotelBooking.Models;
using HotelBooking.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Pages.Empleados
{
    public class CreateModel : PageModel
    {
        private readonly HotelBookingContext _context;

        public CreateModel(HotelBookingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Empleado Empleado { get; set; }

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

            _context.Empleados.Add(Empleado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}