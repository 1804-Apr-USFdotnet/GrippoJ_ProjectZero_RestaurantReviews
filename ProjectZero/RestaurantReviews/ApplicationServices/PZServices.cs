using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PZModels;
using PZRepositories;
using PZServices;

namespace ApplicationServices
{
    public class PZServices
    {
        private readonly PZRepoContext _db;
        private readonly RestaurantService _restaurantService;

        public PZServices()
        {
            _db = new PZRepoContext();
            _restaurantService = new RestaurantService(new RestaurantRepo(_db));
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _restaurantService.AllRestaurants();
        }
    }
}
