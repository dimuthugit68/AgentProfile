using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agent_profile.Models
{
    public class ReviewModel
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public AgentModel Agent { get; set; }
    }
}
