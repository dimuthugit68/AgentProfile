using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agent_profile.Models;

namespace Agent_profile.ViewModels
{
    public class AgentReviewVM
    {
        public AgentReviewVM()
        {
            Review = new List<ReviewModel>();
        }
        public List<ReviewModel> Review { get; set; }
        public decimal AvgReview { get; set; }
        public string Comment { get; set; }
        public string ReviewOn { get; set; }
        public string ReviewBy { get; set; }
        public string ReviewFrom { get; set; }
    }
}
