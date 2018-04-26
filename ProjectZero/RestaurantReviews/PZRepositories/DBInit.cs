using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZRepositories
{
    class DBInit : CreateDatabaseIfNotExists<PZRepoContext>
    {
        protected override void Seed(PZRepoContext context)
        {
            base.Seed(context);
        }
    }
}
