using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServices
{
    public class Review
    {
        public int AppRating { get; set; }
        public int ServiceRating { get; set; }
        public string ServiceReview {  get; set; }
        public string AppReview {  get; set; }

        public string toString()
        {
            return $"App experience rating: {AppRating}, " +
                $"\nApp review: {AppReview}" +
                $"\nService delivery experience rating: {ServiceRating}, " +
                $"\nWritten Review: {ServiceReview}";
        }
    }
}
