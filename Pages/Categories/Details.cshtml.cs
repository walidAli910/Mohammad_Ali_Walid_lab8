using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mohammad_Ali_Walid_lab8.Data;
using Mohammad_Ali_Walid_lab8.Models;

namespace Mohammad_Ali_Walid_lab8.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Mohammad_Ali_Walid_lab8.Data.Mohammad_Ali_Walid_lab8Context _context;

        public DetailsModel(Mohammad_Ali_Walid_lab8.Data.Mohammad_Ali_Walid_lab8Context context)
        {
            _context = context;
        }

        public CategoryModel CategoryModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategoryModel = await _context.CategoryModel.FirstOrDefaultAsync(m => m.ID == id);

            if (CategoryModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
