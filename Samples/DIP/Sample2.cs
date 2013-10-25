namespace Samples.DIP
{
    public class OrderProcesserWithDip
    {
        private readonly IDiscountCalculator discountCalculator;
        private readonly ITaxCalculator taxCalculator;

        public OrderProcesserWithDip(
            IDiscountCalculator discountCalculator, 
            ITaxCalculator taxCalculator)
        {
            this.discountCalculator = discountCalculator;
            this.taxCalculator = taxCalculator;
        }

        public decimal CalculateTotal(Order order)
        {
            return (order.GetItemTotal()
                - discountCalculator.Calculate(order)) 
                + taxCalculator.Calculate(order);
        }
    }

    public interface IDiscountCalculator
    {
        decimal Calculate(Order order);
    }

    public interface ITaxCalculator
    {
        decimal Calculate(Order order);
    }
}