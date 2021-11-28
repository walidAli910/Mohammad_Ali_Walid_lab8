using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mohammad_Ali_Walid_lab8.Data;
using Mohammad_Ali_Walid_lab8.Models;

namespace Mohammad_Ali_Walid_lab8.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Mohammad_Ali_Walid_lab8.Data.Mohammad_Ali_Walid_lab8Context _context;

        public CreateModel(Mohammad_Ali_Walid_lab8.Data.Mohammad_Ali_Walid_lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CategoryModel CategoryModel { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CategoryModel.Add(CategoryModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
