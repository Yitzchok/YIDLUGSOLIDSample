using System.Collections.Generic;

namespace Samples.OCP
{
    public class ProductFilterOcp
    {
        public IEnumerable<Product> By(IEnumerable<Product> products,
            ProductFilterSpecification specification)
        {
            return specification.Filter(products);
        }
    }
}