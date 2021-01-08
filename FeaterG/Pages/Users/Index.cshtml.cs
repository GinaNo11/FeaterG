using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeaterG.Data;
using FeaterG.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FeaterG.Pages.Users
{
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<ApplicationUser> ApplicationUserList { get; set; }
        public async Task<IActionResult> OnGet()
        {
            ApplicationUserList = await _db.ApplicationUser.ToListAsync();
            return Page();
        }
    }
}
