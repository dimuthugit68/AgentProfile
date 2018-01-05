using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agent_profile.Models;

namespace Agent_profile.ViewModels
{
    public class AgentVM
    {
        public AgentVM()
        {
            Review = new List<ReviewModel>();
            Sort = new List<SortList>();
        }
        public AgentModel Agent { get; set; }
        public List<ReviewModel> Review { get; set; }
        public decimal AvgReview { get; set; }
        public List<ActiveListingModel> ActiveListing { get; set; }
        public PastSaleVM PastSale { get; set; }
        public List<SortList> Sort { get; set; }
    }
}
