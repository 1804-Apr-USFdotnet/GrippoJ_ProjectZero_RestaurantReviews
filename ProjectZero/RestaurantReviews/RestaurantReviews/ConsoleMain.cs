using ApplicationClient;

namespace RestaurantReviews
{
    class ConsoleMain
    {
        static void Main(string[] args)
        {
            var order = "address";
            var application = new PZClient();
            //application.PrintAllRestaurants();
            //application.PrintTopThree();
            application.PrintByOrder(order);
        }
    }
}
