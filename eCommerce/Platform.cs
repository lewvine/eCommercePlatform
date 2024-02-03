using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    internal class Platform
    {
        List<Product> inventory;

        public Platform()
        {
            this.inventory = new List<Product>();
        }

        public Product CreateProduct(int uniqueIdentifier, string name, string category, double price, double averageRating)
        {
            Product product = new Product(uniqueIdentifier, name, category, price, averageRating);
            return product;
        }

        public void PopulateInventory(Product product)
        {
            inventory.Add(product);
        }

        public void UsePlatform(Consumer consumer)
        {
            //Search for product
            Product product = consumer.searchProducts("baseball ball", inventory);

            //See information about product
            consumer.printProductInfo(product);

            //Add product to shopping cart
            consumer.AddToShoppingCart(product);

            //Give product a rating and review
            consumer.ReviewProduct(product);

        }
    }
}
