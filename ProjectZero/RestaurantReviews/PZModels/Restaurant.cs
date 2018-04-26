using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZModels
{
    public class Restaurant
    {
        public int rIndex { get; set; }
        public int FranchiseID { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public string state { get; set; }
        public string address { get; set; }
        public double avgRating  { get; set; }

        public override string ToString()
        {
            return
                $"\nindex: {rIndex}\nfIndex: {FranchiseID}\nname: {name} \ncity: {city}\nZip: {zipcode}\nstate: {state}\naddress: {address}\naverage rating: {avgRating}\n";
        }

        public void calcAvgRating(IEnumerable<Review> reviews)
        {
            avgRating = reviews.Select(x => x.Rating).Average();    
        }
    }
}
