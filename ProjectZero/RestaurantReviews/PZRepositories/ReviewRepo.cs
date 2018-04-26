using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PZModels;
using PZRepositoryInterface;

namespace PZRepositories
{
    class ReviewRepo : IReviewRepo
    {
        private readonly PZRepoContext _pzRepoContext;

        public ReviewRepo(PZRepoContext context)
        {
            _pzRepoContext = context;
        }
        public Review GetById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Review> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Review> GetByRestaurantId()
        {
            throw new NotImplementedException();
        }

        public void Add(Review review)
        {
            throw new NotImplementedException();
        }

        public void UpdateReviews()
        {
            throw new NotImplementedException();
        }
    }
}
