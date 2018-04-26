using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PZModels;

namespace PZRepositories
{
    public class PZRestaurantContext : DbContext
    {
        public PZRestaurantContext() : base("name=PZRestaurantConnectionString")
        {
            Database.SetInitializer<PZRestaurantContext>();
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
