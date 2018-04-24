using System;
using System.Collections.Generic;
using System.Text;
using PZModels;

namespace IPZServices
{
    public interface IReviewService
    {
        List<Review> AllReviews();
        List<Review> ReviewById();
    }
}
