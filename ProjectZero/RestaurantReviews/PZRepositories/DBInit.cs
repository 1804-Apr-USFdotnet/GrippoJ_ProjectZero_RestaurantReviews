using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZRepositories
{
    class DBInit : CreateDatabaseIfNotExists<PZRestaurantContext>
    {
        protected override void Seed(PZRestaurantContext context)
        {
            base.Seed(context);
        }
    }
}
