namespace Samples.DIP
{
    public class OrderProcesser
    {
        public decimal CalculateTotal(Order order)
        {
            var itemTotal = order.GetItemTotal();

            var discountAmount = DiscountCalculator.CalculateDiscount(order);

            decimal taxAmount = 0;

            //this doesn't work :)
            if (order.Country == "US")
                taxAmount = FindTaxAmount(order);
            if (order.Country == "UK")
                taxAmount = FindVatAmount(order);

            return (itemTotal - discountAmount) + taxAmount;
        }

        private decimal FindVatAmount(Order order)
        {
            //get the tax somehow.
            return 8m;
        }

        private decimal FindTaxAmount(Order order)
        {
            //get the tax somehow.
            return 8m;
        }
    }

    public class DiscountCalculator
    {
        public static decimal CalculateDiscount(Order order)
        {
            if (order.GetItemTotal() > 20)
            {
                return 20;
            }
            if (order.GetItemTotal() > 5)
            {
                return 10;
            }

            return 0;
        }
    }

    public class Order
    {
        public decimal GetItemTotal()
        {
            return 10m;
        }

        public string Country { get; set; }
    }
}