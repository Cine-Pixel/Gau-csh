using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1 {
    public abstract class Product {
        public abstract string Info();

        public static List<Product> Search(List<Product> products, DateTime begin, DateTime end) {
            List<Product> _products = new List<Product>(products);
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in _products) {
                if(product.GetType() == typeof(Book)) {
                    if(((Book)product).PblishDate > begin && ((Book)product).PblishDate < end) {
                        filteredProducts.Add(product);
                    }
                } else if(product.GetType() == typeof(Article)) {
                    if(((Article)product).PblishDate > begin && ((Article)product).PblishDate < end) {
                        filteredProducts.Add(product);
                    }
                } else {
                    continue;
                } 
            }

            return filteredProducts;
        }
        public static List<Product> TopM(List<Product> products, int m) {
            List<Product> filtered = new List<Product>();
            foreach(var product in products) {
                if(product.GetType() == typeof(Book)) {
                    if(((Book)product).PageNumber > m) {
                        filtered.Add(product);
                    }
                }
            }
            return filtered;
        }
    }
}
