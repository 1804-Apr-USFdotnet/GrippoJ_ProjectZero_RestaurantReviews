using System;
using System.Collections.Generic;
using System.Text;
using PZModels;

namespace PZRepositoryInterface
{
    public interface IFranchiseRepo
    {
        Franchise GetById();
        IEnumerable<Franchise> GetAll();
        IEnumerable<Franchise> GetByGenre();
        void Add(Franchise franchise);
        void UpdateFranchises();
    }
}
