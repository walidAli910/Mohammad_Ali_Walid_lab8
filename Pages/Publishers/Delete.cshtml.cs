using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mohammad_Ali_Walid_lab8.Data;
using Mohammad_Ali_Walid_lab8.Models;

namespace Mohammad_Ali_Walid_lab8.Pages.Publishers
{
    public class DeleteModel : PageModel
    {
        private readonly Mohammad_Ali_Walid_lab8.Data.Mohammad_Ali_Walid_lab8Context _context;

        public DeleteModel(Mohammad_Ali_Walid_lab8.Data.Mohammad_Ali_Walid_lab8Context context)
        {
            _context = context;
        }

        [BindProperty]
        public PublisherModel PublisherModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PublisherModel = await _context.PublisherModel.FirstOrDefaultAsync(m => m.ID == id);

            if (PublisherModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PublisherModel = await _context.PublisherModel.FindAsync(id);

            if (PublisherModel != null)
            {
                _context.PublisherModel.Remove(PublisherModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
