using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeaterG.Data;
using FeaterG.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FeaterG.Pages.Cars
{
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public UserCars UserCars { get; set; }
        public async Task<IActionResult> OnGet(string UserId)
        {
            UserCars = new UserCars
            {
                User = await _db.ApplicationUser.FirstOrDefaultAsync(m => m.Id == UserId),
                Cars = await _db.Car.Where(m => m.UserId == UserId).ToListAsync()
            };
            return Page();
        }

    }
}
