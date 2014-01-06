namespace ASPPatterns.Chap3.Layered.Model
{
    public class TradeDiscountStrayegy : IDiscountStrategy
    {
        public decimal ApplyExtraDiscountTo(decimal originalSalePrice)
        {
            var price = originalSalePrice;

            price = price*0.96M;

            return price;
        }
    }
}
