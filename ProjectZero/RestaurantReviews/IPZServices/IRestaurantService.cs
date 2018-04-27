using System;
using System.Collections.Generic;
using PZModels;

namespace IPZServices
{
    public interface IRestaurantService
    {
        List<Restaurant> AllRestaurants();
        Restaurant RestaurantById(int id);
        List<Restaurant> GetTopThreeRestaurants();
        List<Restaurant> GetRestaurantsByOrder(string order);
    }
}
