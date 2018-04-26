using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PZModels;
using PZRepositoryInterface;

namespace PZRepositories
{
    class FranchiseRepo : IFranchiseRepo
    {
        private readonly PZRepoContext _pzRepoContext;

        public FranchiseRepo(PZRepoContext context)
        {
            _pzRepoContext = context;
        }
        public Franchise GetById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Franchise> GetAll()
        {
            throw new NotImplementedException();
        }


        public void Add(Franchise franchise)
        {
            throw new NotImplementedException();
        }

        public void UpdateFranchises()
        {
            throw new NotImplementedException();
        }
    }
}
