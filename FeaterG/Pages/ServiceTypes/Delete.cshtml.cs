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
    public class DeleteModel : PageModel
    {

        public readonly ApplicationDbContext _db;

        [BindProperty]
        public ServiceType ServiceType { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> OnGetAsync(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            ServiceType = await _db.ServiceType.FirstOrDefaultAsync(m => m.Id == Id);

            return Page();

            //if( ServiceType == null)
            //{
            //    return NotFound();
            //}
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ServiceType == null)
            {
                return NotFound();
            }
            _db.ServiceType.Remove(ServiceType);
             await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
