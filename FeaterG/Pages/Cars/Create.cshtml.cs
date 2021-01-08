using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeaterG.Data;
using FeaterG.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;

namespace FeaterG.Pages.Cars
{
    public class CreateModel : PageModel
    {
        public readonly ApplicationDbContext _db;
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;  
        }

        [BindProperty]
        public Car Car { get; set; }
        public async Task<IActionResult> OnGet(string UserId)
        {
            Car = new Car();
            Car.UserId = UserId;
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            _db.Car.Add(Car);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index", new{ UserId= Car.UserId });
        }
    }
}
