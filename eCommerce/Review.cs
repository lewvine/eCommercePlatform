using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    internal class Review
    {
        public double rating;
        public string text;

        public Review(double rating, string text)
        {
            this.rating = rating;
            this.text = text;
        }
    }
}
