using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationServices;
using PZModels;

namespace ApplicationClient
{
    public class PZClient
    {
        private readonly PZServices _pzServices;

        public PZClient()
        {
            _pzServices = new PZServices();
        }

        public void PrintAllRestaurants()
        {
            List<Restaurant> restaurants = _pzServices.GetAllRestaurants();

            foreach (Restaurant r in restaurants)
            {
                Console.WriteLine(r.ToString());
            }

            Console.ReadLine();
        }
    }
}
