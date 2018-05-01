using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PZModels;
using PZRepositoryInterface;
using PZServices;

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
        public void GetTopThree_CallsGetAllOnce()
        {
            var service = new RestaurantService(_moqRepo.Object);
            service.GetTopThreeRestaurants();

            _moqRepo.Verify(m=>m.GetAll(),Times.Once);

        }

        [TestMethod]
        public void AllRestuarants_CallsGetAllOnce()
        {
            var service = new RestaurantService(_moqRepo.Object);
            service.AllRestaurants();

            _moqRepo.Verify(m => m.GetAll(), Times.Once);
        }

        [TestMethod]
        public void RestuarantById_CallsGetByIdOnce()
        {
            var service = new RestaurantService(_moqRepo.Object);
            service.RestaurantById(It.IsAny<int>());

            _moqRepo.Verify(m => m.GetById(It.IsAny<int>()), Times.Once);
        }

        [TestMethod]
        public void RestuarantByName_CallsGetByNameOnce()
        {
            var service = new RestaurantService(_moqRepo.Object);
            service.RestaurantByName(It.IsAny<string>());

            _moqRepo.Verify(m => m.GetByName(It.IsAny<string>()), Times.Once);
        }
    }
}
