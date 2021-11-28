using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mohammad_Ali_Walid_lab8.Models;

namespace Mohammad_Ali_Walid_lab8.Data
{
    public class Mohammad_Ali_Walid_lab8Context : DbContext
    {
        public Mohammad_Ali_Walid_lab8Context (DbContextOptions<Mohammad_Ali_Walid_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Mohammad_Ali_Walid_lab8.Models.BookModel> BookModel { get; set; }

        public DbSet<Mohammad_Ali_Walid_lab8.Models.PublisherModel> PublisherModel { get; set; }

        public DbSet<Mohammad_Ali_Walid_lab8.Models.CategoryModel> CategoryModel { get; set; }
    }
}
