using System;
using System.Collections.Generic;
using PZModels;

namespace IPZServices
{
    public interface IRestaurantService
    {
        List<Restaurant> AllRestaurants();
        List<Restaurant> RestaurantById();
        List<Restaurant> GetTopThreeRestaurants();

    }
}
