using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    internal class ShoppingCart
    {
        public List<Product> products;
        public double totalCostProducts;

        public ShoppingCart()
        {
            this.products = new List<Product>();
        }

        public void UpdateTotalCost(List<Product> products)
        {
            double totalCost = 0;
            foreach(Product product in products)
            {
                totalCost += product.price;
            }
            this.totalCostProducts = totalCost;
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
            totalCostProducts -= product.price;
        }
    }
}
