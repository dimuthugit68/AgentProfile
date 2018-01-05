using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agent_profile.Models
{
    public class PastSaleModel
    {
        public int Id { get; set; }
        public string PropertyImage { get; set; }
        public string Details { get; set; }
        public string Represented { get; set; }
        public decimal Price { get; set; }
    }
}
