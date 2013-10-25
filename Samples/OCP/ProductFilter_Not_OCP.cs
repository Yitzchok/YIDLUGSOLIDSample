using System.Collections.Generic;
namespace Samples.OCP
{
    public class ProductFilter
    {
        public IEnumerable<Product> ByColor(IEnumerable<Product> products, string color)
        {
            foreach (Product product in products)
            {
                if (product.Color == color) yield return product;
            }
        }


        public IEnumerable<Product> BySize(IEnumerable<Product> products, string size)
        {
            foreach (Product product in products)
            {
                if (product.Size == size) yield return product;
            }
        }

        public IEnumerable<Product> ByColorAndSize(IEnumerable<Product> products, string color, string size)
        {
            foreach (Product product in products)
            {
                if (product.Color == color && product.Size == size) yield return product;
            }
        }
    }
}