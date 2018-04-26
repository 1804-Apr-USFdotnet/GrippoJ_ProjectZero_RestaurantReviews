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

        public List<Restaurant> RestaurantById()
        {
            throw new System.NotImplementedException();
        }

        public List<Restaurant> GetTopThreeRestaurants()
        {
            throw new System.NotImplementedException();
        }
    }
}
