using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    internal class Product
    {
        public int uniqueIdentifier;
        public string name;
        public string category;
        public double price;
        public double averageRating;
        public List<Review> reviews;

        public Product(int uniqueIdentifier, string name, string category, double price, double averageRating)
        {
            this.uniqueIdentifier = uniqueIdentifier;
            this.name = name;
            this.category = category;
            this.price = price;
            this.averageRating = averageRating;
            this.reviews = new List<Review>();
        }

        public string getName()
        {
            return this.name;
        }

        public void updateRating(Review review)
        {
            reviews.Add(review);

            double totalRatings = 0;
            double ratingsCount = 0;
            foreach(Review r in reviews)
            {
                totalRatings += r.rating;
                ratingsCount++;
            }
            this.averageRating = (totalRatings / ratingsCount);
        }

        private void PopulateReview(Review review)
        {
            reviews.Add(review);
        }

    }
}
