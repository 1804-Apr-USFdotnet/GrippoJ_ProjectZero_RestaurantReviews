using System;
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
        private readonly Mock<IReviewRepo> _moqRepo;
        private readonly Restaurant r;

        public RestaurantRepoTest()
        {
            _moqContext = new Mock<IPZRepoContext>();
            _moqSet = new Mock<DbSet<Restaurant>>();
            _moqRepo = new Mock<IReviewRepo>();

            _moqContext.Setup(m => m.Restaurants).Returns(_moqSet.Object);

            r = new Restaurant
            {
                rIndex = 1,
                FranchiseID = 1,
                Name = "TestRestaurant",
                City = "city",
                Zipcode = "10801",
                State = "NY",
                Address = " 1 a",
                AvgRating = 6.9
            };
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
    }
}
