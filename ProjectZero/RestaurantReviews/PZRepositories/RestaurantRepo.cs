﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PZModels;
using PZRepositoryInterface;

namespace PZRepositories
{
    class RestaurantRepo : IRestaurantRepo
    {
        private readonly PZRepoContext _pzRepoContext;

        public RestaurantRepo(PZRepoContext context)
        {
            _pzRepoContext = context;
        }

        public Restaurant GetById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Restaurant> GetByFranchiseId()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Restaurant> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public void UpdateRestaurants()
        {
            throw new NotImplementedException();
        }
    }
}