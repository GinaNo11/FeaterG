using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeaterG.Data;
using FeaterG.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FeaterG.Pages.ServiceTypes
{
    public class DetailsModel : PageModel
    {
        public readonly ApplicationDbContext _db;
        public ServiceType ServiceType { get; set; }
        public DetailsModel( ApplicationDbContext db)
        {
            _db = db; 
        }
        public async Task<IActionResult> OnGet( int? Id)
        {
            if (Id == null) return NotFound();
            ServiceType = await _db.ServiceType.FirstOrDefaultAsync(m => m.Id == Id);

            return Page();
        }
    }
}
