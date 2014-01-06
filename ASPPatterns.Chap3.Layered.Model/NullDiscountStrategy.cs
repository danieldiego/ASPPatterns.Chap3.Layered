namespace ASPPatterns.Chap3.Layered.Model
{
    public class NullDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyExtraDiscountTo(decimal originalSalePrice)
        {
            return originalSalePrice;
        }
    }
}
