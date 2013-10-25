using System.Collections.Generic;

namespace Samples.OCP
{
    public abstract class ProductFilterSpecification
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products)
        {
            foreach (Product product in products)
            {
                if (Check(product))
                    yield return product;
            }
        }

        protected abstract bool Check(Product product);
    }

    public class ByColorProductFilterSpecification : ProductFilterSpecification
    {
        private readonly string color;

        public ByColorProductFilterSpecification(string color)
        {
            this.color = color;
        }

        protected override bool Check(Product product)
        {
            return product.Color == color;
        }
    }

    public class ByColorAndSizeProductFilterSpecification : ProductFilterSpecification
    {
        private readonly string color;
        private readonly string size;

        public ByColorAndSizeProductFilterSpecification(string color, string size)
        {
            this.color = color;
            this.size = size;
        }

        protected override bool Check(Product product)
        {
            return product.Color == color && product.Size == size;
        }
    }

    public class BySizeProductFilterSpecification : ProductFilterSpecification
    {
        private readonly string size;

        public BySizeProductFilterSpecification(string size)
        {
            this.size = size;
        }

        protected override bool Check(Product product)
        {
            return product.Size == size;
        }
    }
}