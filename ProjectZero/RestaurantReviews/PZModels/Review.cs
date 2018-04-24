using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZModels
{
    public class Review
    {
        public Guid Id { get; set; }
        public string RestaurantKey { get; set; }
        public string Reviewer { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }

        public override string ToString()
        {
            return $"\nReviewer: {Reviewer}\nReview: {Description}\nRating: {Rating}\n";
        }
    }
}
