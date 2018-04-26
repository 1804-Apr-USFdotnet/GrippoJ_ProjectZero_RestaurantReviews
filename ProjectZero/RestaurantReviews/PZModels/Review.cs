using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZModels
{
    public class Review
    {
        public int revIndex { get; set; }
        public int RestaurantID { get; set; }
        public string Reviewer { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public DateTime rDate { get; set; }

        public override string ToString()
        {
            return $"\nrevIndex: {revIndex}\nRestaurantID: {RestaurantID}\nReviewer: {Reviewer}\nReview: {Description}\nRating: {Rating}\nrDate: {rDate}\n";
        }
    }
}
