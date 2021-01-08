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
    public class EditeModel : PageModel
    {
        public readonly ApplicationDbContext _db;

        [BindProperty]
        public ServiceType ServiceType{ get; set; }

        public ServiceType ServiceChange { get; set; }

        public EditeModel( ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> OnGetAsync( int? Id)
        {
            
            if( Id ==null) return NotFound();
             

            ServiceType = await _db.ServiceType.FirstOrDefaultAsync(m=> m.Id==Id);

            if (ServiceType == null) return NotFound();
            
            return  Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ServiceChange = await _db.ServiceType.FirstOrDefaultAsync(m => m.Id == ServiceType.Id);
            ServiceChange.ServiceName = ServiceType.ServiceName;
            ServiceChange.Price = ServiceType.Price;

            // await _db.ServiceType.AddAsync(ServiceType);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
