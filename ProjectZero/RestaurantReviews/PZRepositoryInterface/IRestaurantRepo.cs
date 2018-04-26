using System;
using System.Collections.Generic;
using PZModels;

namespace PZRepositoryInterface
{
    public interface IRestaurantRepo
    {
        Restaurant GetById();
        IEnumerable<Restaurant> GetByFranchiseId(); 
        IEnumerable<Restaurant> GetAll();
        void Add(Restaurant restaurant);
        void UpdateRestaurants();
    }
}
