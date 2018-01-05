using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agent_profile.Models
{
    public class ActiveListingModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public bool IsFavariot { get; set; }
        public decimal Value { get; set; }
        public int Bed { get; set; }
        public decimal Bath { get; set; }
        public long SQFT { get; set; }
    }
}
