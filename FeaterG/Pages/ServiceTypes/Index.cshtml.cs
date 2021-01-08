using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeaterG.Data;
using FeaterG.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FeaterG.Pages.ServiceTypes
{
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _db;
        public List<ServiceType> ServiceTypeList { get; set; }

        public IndexModel( ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult OnGet()
        {
            ServiceTypeList = _db.ServiceType.ToList() ;
            return Page();
                
        }
    }
}
