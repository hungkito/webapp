using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapp
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Unit { get; set; }
    }
}
