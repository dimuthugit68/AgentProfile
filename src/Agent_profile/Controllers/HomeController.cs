using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agent_profile.ViewModels;
using Agent_profile.Models;

namespace Agent_profile.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var Agent = new AgentModel();
            var AgentProfile = new AgentVM();
            Agent.Id = 0001;
            Agent.Name = "Melissa Crosby";
            Agent.About = "<p>Being a full - service Realtor since 2007, I have been baptized by fire in a very tough housing market.I have successfully closed over 60 transactions and processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes.I strive to exceed expectations and never forget that I am always accountable to my clients.</ p >" +
                    "<p> My objective is to establish relationships for life, not just for the current transaction.I enjoy assisting home buyers and sellers to get moved to a better place, one that is exciting. </ p >" +
                    "<p class='l-small'><strong>Brokerage:</strong> Berkshire Hathaway HomeServices Elite Real Estate</p>" +
                    "<p class='l-small'><strong>Specialties:</strong> Property Management, Buyer’s Agent, Listing Agent…</p>" +
                    "<p class='l-small'><strong>License Number(s):</strong> #5452129</p>";


            //Reviews 1
            var Reviews = GetReviewList();

            //Agent Reviews 1
            var comment = "Being a full-service Realtor since 2007, I have been baptized by fire in a very tough housing market. I have successfully closed over 60 transactions and processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes. I strive to exceed expectations and never forget that I am always accountable to my clients.";
            var AgentReview = GetAgentReview(comment, Reviews);
            AgentProfile.Review.Add(AgentReview);

            //Reviews 2
            Reviews = GetReviewList();

            //Agent Reviews 2
            comment = "Most important to me was communication and Mark saw that every question or concern of ours we met with full and complete information. In most cases, Mark delivered information to us before we even had to ask. I look forward to working with Mark in the future because I know that I can trust him to";
            AgentReview = GetAgentReview(comment, Reviews);
            AgentProfile.Review.Add(AgentReview);

            AgentProfile.ActiveListing = GetActiveList();
            AgentProfile.Agent = Agent;
            AgentProfile.AvgReview = 4.5M;

            return View(AgentProfile);
        }

        private List<ReviewModel> GetReviewList()
        {
            var Reviews = new List<ReviewModel>();
            var review1 = new ReviewModel()
            {
                Id = 0,
                Description = "Local knowledge",
                Review = 4.5M
            };
            var review2 = new ReviewModel()
            {
                Id = 0,
                Description = "Process expertise",
                Review = 4.2M
            };
            var review3 = new ReviewModel()
            {
                Id = 0,
                Description = "Responsiveness",
                Review = 5.0M
            };
            var review4 = new ReviewModel()
            {
                Id = 0,
                Description = "Negotiation Skills",
                Review = 4.1M
            };
            Reviews.Add(review1);
            Reviews.Add(review2);
            Reviews.Add(review3);
            Reviews.Add(review4);

            return Reviews;
        }

        private AgentReviewVM GetAgentReview(string Comment, List<ReviewModel> Reviews)
        {
            var AgentReview = new AgentReviewVM();
            AgentReview.Review = Reviews;
            AgentReview.AvgReview = 4.5M;
            AgentReview.Comment = Comment;
            AgentReview.ReviewOn = "09/24/2017";
            AgentReview.ReviewBy = "russroberts";
            AgentReview.ReviewFrom = "Bought a home in 2017 in El Cajon, CA";

            return AgentReview;
        }

        private List<ActiveListingModel> GetActiveList()
        {
            var ActiveList = new List<ActiveListingModel>();
            ActiveList.Add(GetProperty(345000M, "472 Ponderosa Dr, Alpine", 4, 3.0M, 2785, false, "/images/home1.jpg", 6.5M));
            ActiveList.Add(GetProperty(345000M, "472 Ponderosa Dr, Alpine", 4, 3.0M, 2785, true, "/images/home8.jpg", 10));
            ActiveList.Add(GetProperty(345000M, "472 Ponderosa Dr, Alpine", 4, 3.0M, 2785, false, "/images/home11.jpg", 0));

            return ActiveList;
        }

        private ActiveListingModel GetProperty(decimal value, string Description, int Bed, decimal bath, long SQFT, bool isFavorit, string img, decimal pricechange)
        {
            var property = new ActiveListingModel()
            {
                Value = value,
                Name = Description,
                Bath = bath,
                Bed = Bed,
                Sqft = SQFT,
                IsFavariot = isFavorit,
                Image = img,
                pricecange = pricechange
            };

            return property;
        }
    }
}
