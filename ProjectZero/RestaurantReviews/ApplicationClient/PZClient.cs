using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationServices;
using PZModels;

namespace ApplicationClient
{
    public class PZClient
    {
        private readonly PZServices _pzServices;

        public PZClient()
        {
            _pzServices = new PZServices();
        }

        public void PrintAllRestaurants()
        {
            List<Restaurant> restaurants = _pzServices.GetAllRestaurants();
            Print(restaurants);
        }

        public void PrintTopThree()
        {
            List<Restaurant> restaurants = _pzServices.GetTopThreeRestaurants();
            Print(restaurants);
        }

        public void PrintByOrder(string order)
        {
            List<Restaurant> restaurants = _pzServices.GetRestaurantsByOrder(order);
            Print(restaurants);
        }

        public void PrintReviewsForRestaurant(int id)
        {
            List<Review> reviews = _pzServices.GetAllReviewsForRestaurant(id);
            Print(reviews);
        }

        public void PrintRestaurantSearch(string search)
        {
            List<Restaurant> restaurants = _pzServices.GetRestaurantBySearch(search);
            Print(restaurants);
        }

        public void Print<T>(List<T> data)
        {
            foreach(var r in data)
            {
                Console.WriteLine(r.ToString());
            }
            Console.ReadLine();
        }
    }
}
