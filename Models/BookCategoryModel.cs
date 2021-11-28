using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mohammad_Ali_Walid_lab8.Models
{
    public class BookCategoryModel
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public BookModel Book { get; set; }
        public int CategoryID { get; set; }
        public CategoryModel Category { get; set; }
    }
}
