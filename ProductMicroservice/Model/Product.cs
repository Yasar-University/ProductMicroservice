using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroservice.Model
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public int CategoryId { get; set; }
    }
}
