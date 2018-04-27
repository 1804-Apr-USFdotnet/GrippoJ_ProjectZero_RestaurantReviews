using ApplicationClient;

namespace RestaurantReviews
{
    class ConsoleMain
    {
        static void Main(string[] args)
        {
            var application = new PZClient();
            //application.PrintAllRestaurants();
            application.PrintTopThree();
        }
    }
}
