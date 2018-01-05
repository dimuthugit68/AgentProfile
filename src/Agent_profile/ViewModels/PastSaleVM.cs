using Agent_profile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agent_profile.ViewModels
{
    public class PastSaleVM
    {
        public List<PastSaleModel> PastSale { get; set; }
        public int curruntpage { get; set; }
        public int itemcount { get; set; }
    }
}
