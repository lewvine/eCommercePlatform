using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace eCommerce
{
    internal class Consumer
    {
        string firstName;
        string lastName;
        ShoppingCart shoppingCart;

        public Consumer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.shoppingCart = new ShoppingCart();
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public Product searchProducts(string name, List<Product> inventory)
        {
            foreach(Product product in inventory)
            {
                if(product.getName() == name)
                {
                    return product;
                }
            }
            return null;
        }

        public void printProductInfo(Product product)
        {
            Console.WriteLine($"{product.name} - ${product.price} - {product.averageRating}");
        }

        public void AddToShoppingCart(Product product)
        {
            this.shoppingCart.products.Add(product);
        }

        //Create a method to give a product a rating and review.
        //This method must return the Review object from the method
        //(this will be similar to what you did with the CreateProduct method)

        public Review ReviewProduct(Product product)
        {
            Console.WriteLine("Please give this product a rating");
            double rating;
            double.TryParse(Console.ReadLine(), out rating);
            Console.WriteLine("Please give this product a review");
            string reviewText = Console.ReadLine();
            Review review = new Review(rating, reviewText);
            return review;
        }
    }
}
