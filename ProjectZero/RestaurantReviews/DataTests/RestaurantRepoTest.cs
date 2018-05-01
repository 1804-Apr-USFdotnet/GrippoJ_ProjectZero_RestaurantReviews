using System;
using System.Collections.Generic;
using System.Data.Entity;
using IPZServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PZModels;
using PZRepositories;
using PZRepositoryInterface;
using PZServices;

namespace DataTests
{
    [TestClass]
    public class RestaurantRepoTest
    {
        private readonly Mock<IPZRepoContext> _moqContext;
        private readonly Mock<DbSet<Restaurant>> _moqSet;
        private readonly Restaurant r;
        private readonly List<Restaurant> restaurants;

        public RestaurantRepoTest()
        {
            _moqContext = new Mock<IPZRepoContext>();
            _moqSet = new Mock<DbSet<Restaurant>>();

            _moqContext.Setup(m => m.Restaurants).Returns(_moqSet.Object);

            #region restaurants

            restaurants = new List<Restaurant>()
            {
                new Restaurant
                {
                    rIndex = 1,
                    FranchiseID = 1,
                    Name = "ZestRestaurant",
                    City = "Zcity",
                    Zipcode = "90801",
                    State = "ZNY",
                    Address = "Z 1 a",
                    AvgRating = 6.9
                },
                new Restaurant
                {
                    rIndex = 2,
                    FranchiseID = 2,
                    Name = "TestRestaurant2",
                    City = "city2",
                    Zipcode = "10802",
                    State = "NY",
                    Address = " 2 a",
                    AvgRating = 7.9
                },
                new Restaurant
                {
                    rIndex = 3,
                    FranchiseID = 3,
                    Name = "TestRestaurant3",
                    City = "city3",
                    Zipcode = "10803",
                    State = "NY",
                    Address = " 3 a",
                    AvgRating = 8.9
                },
                new Restaurant
                {
                    rIndex = 4,
                    FranchiseID = 4,
                    Name = "TestRestaurant4",
                    City = "city4",
                    Zipcode = "10804",
                    State = "NY",
                    Address = " 4 a",
                    AvgRating = 9.9
                }
            };

            #endregion
            _moqContext.Setup()
        }

        [TestMethod]
        public void Add_PassedARestaurant_CallsRestaurantRepoAdd()
        {
            var service = new RestaurantRepo(_moqContext.Object);
            service.Add(r);

            _moqSet.Verify(m=>m.Add(It.IsAny<Restaurant>()), Times.Once);
        }

        [TestMethod]
        public void Add_PassedARestaurant_CallsContextSaveChanges()
        {
            var service = new RestaurantRepo(_moqContext.Object);
            service.Add(r);

            _moqContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetById_PassedInt_AssertReturnType()
        {
            var service = new RestaurantRepo(_moqContext.Object);
            var restById = service.GetById(It.IsAny<int>());

            //Assert.IsInstanceOfType(restById, typeof(Restaurant));
        }

        [TestMethod]
        public void GetByName_PassedString_AssertReturnType()
        {
            var service = new RestaurantRepo(_moqContext.Object);
            var restByName = service.GetByName(It.IsAny<string>());

            //Assert.IsInstanceOfType(restByName, typeof(Restaurant));
        }

        [TestMethod]
        public void GetAll_AssertReturnType()
        {
            var service = new RestaurantRepo(_moqContext.Object);
            var restById = service.GetAll();

            Assert.IsInstanceOfType(restById, typeof(IEnumerable<Restaurant>));
        }
    }
}
