using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PZModels;
using PZRepositoryInterface;

namespace ServicesUnitTests
{
    [TestClass]
    public class RestaurantServiceTest
    {
        private readonly Mock<IRestaurantRepo>_moqRepo;
        private readonly Restaurant r;

        public RestaurantServiceTest()
        {
            _moqRepo = new Mock<IRestaurantRepo>();
            _moqRepo.Setup(m => m.Add(It.IsAny<Restaurant>()));

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
        public void TestMethod1()
        {

        }
    }
}
