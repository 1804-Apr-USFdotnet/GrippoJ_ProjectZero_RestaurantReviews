using System;
using System.Collections.Generic;
using System.Text;
using PZModels;

namespace PZRepositoryInterface
{
    public interface IReviewRepo
    {
        Review GetById();
        IEnumerable<Review> GetAll();
        IEnumerable<Review> GetByRestaurantId();
        void Add(Review review);
        void UpdateReviews();
    }
}
