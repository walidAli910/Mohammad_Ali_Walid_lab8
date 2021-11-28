using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mohammad_Ali_Walid_lab8.Models
{
    public class CategoryModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<BookCategoryModel> BookCategories { get; set; }

    }
}
