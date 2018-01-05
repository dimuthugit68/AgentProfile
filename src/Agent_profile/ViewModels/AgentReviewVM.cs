using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agent_profile.Models;

namespace Agent_profile.ViewModels
{
    public class AgentReviewVM
    {
        public AgentModel Agent { get; set; }
        public List<ReviewModel> Review { get; set; }
        public decimal AvgReview { get; set; }
    }
}
