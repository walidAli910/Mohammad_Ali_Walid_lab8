using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mohammad_Ali_Walid_lab8.Data;
using Mohammad_Ali_Walid_lab8.Models;

namespace Mohammad_Ali_Walid_lab8.Pages.Books
{
    public class DeleteModel : PageModel
    {
        private readonly Mohammad_Ali_Walid_lab8.Data.Mohammad_Ali_Walid_lab8Context _context;

        public DeleteModel(Mohammad_Ali_Walid_lab8.Data.Mohammad_Ali_Walid_lab8Context context)
        {
            _context = context;
        }

        [BindProperty]
        public BookModel BookModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookModel = await _context.BookModel.FirstOrDefaultAsync(m => m.ID == id);

            if (BookModel == null)
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

            BookModel = await _context.BookModel.FindAsync(id);

            if (BookModel != null)
            {
                _context.BookModel.Remove(BookModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
