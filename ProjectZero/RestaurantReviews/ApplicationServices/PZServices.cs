using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PZModels;
using PZRepositories;
using PZRepositoryInterface;
using PZServices;

namespace ApplicationServices
{
    public class PZServices
    {
        private readonly PZRepoContext _db;
        private readonly RestaurantService _restaurantService;
        private readonly ReviewService _reviewService;

        public PZServices()
        {
            _db = new PZRepoContext();
            _restaurantService = new RestaurantService(new RestaurantRepo(_db));
            _reviewService = new ReviewService(new ReviewRepo(_db));
            UpdateAverageRating();
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _restaurantService.AllRestaurants();
        }

        public void UpdateAverageRating()
        {
            List<Restaurant> restList = GetAllRestaurants();
            foreach (Restaurant r in restList)
            {
                List<Review> restReviews = _reviewService.ReviewsByRestaurantId(r.rIndex);
                r.calcAvgRating(restReviews);
            }
        }
    }
}
