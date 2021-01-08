using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeaterG.Data;
using FeaterG.Models;
using FeaterG.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FeaterG.Pages.ServiceTypes
{
    [Authorize(Roles = StaticDetails.AdminUser)]
    public class CreateModel : PageModel
    {
        public readonly ApplicationDbContext _db;

       [BindProperty]
        public ServiceType ServiceType { get; set; }

        public CreateModel( ApplicationDbContext db )
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.ServiceType.Add(ServiceType);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
