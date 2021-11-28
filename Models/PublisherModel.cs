using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mohammad_Ali_Walid_lab8.Models
{
    public class PublisherModel
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<BookModel> Books { get; set; }
    }
}
