using System.Collections.Generic;
using System.Linq;
using IPZServices;
using PZModels;
using PZRepositoryInterface;

namespace PZServices
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepo _restaurantRepo;
        public RestaurantService(IRestaurantRepo restaurantRepo)
        {
            _restaurantRepo = restaurantRepo;
        }

        public List<Restaurant> AllRestaurants()
        {
            return _restaurantRepo.GetAll().ToList();
        }

        public Restaurant RestaurantById(int id)
        {
            return _restaurantRepo.GetById(id);
        }

        public List<Restaurant> GetTopThreeRestaurants()
        {
            IEnumerable<Restaurant> query = _restaurantRepo.GetAll();
            return query.OrderByDescending(x => x.AvgRating).Take(3).ToList();
        }
    }
}
