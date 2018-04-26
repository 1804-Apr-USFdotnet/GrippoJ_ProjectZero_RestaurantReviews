﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPZServices;
using PZModels;
using PZRepositoryInterface;

namespace PZServices
{
    class ReviewService : IReviewService
    {
        private readonly IReviewRepo _pzReviewRepo;

        public ReviewService(IReviewRepo reviewRepo)
        {
            _pzReviewRepo = reviewRepo;
        }
        public List<Review> AllReviews()
        {
            throw new NotImplementedException();
        }

        public Review ReviewById(int id)
        {
            return _pzReviewRepo.GetById(id);
        }

        public List<Review> ReviewsByRestaurantId(int id)
        {
            IEnumerable<Review> query = _pzReviewRepo.GetAll().Where(x => x.RestaurantID == id);
            return query.ToList();
        }
    }
}
