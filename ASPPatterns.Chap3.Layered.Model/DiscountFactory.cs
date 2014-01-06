namespace ASPPatterns.Chap3.Layered.Model
{
    public static class DiscountFactory
    {
        public static IDiscountStrategy GetDiscountStrategyFor(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.Trade: 
                    return new TradeDiscountStrayegy();
                default:
                    return new NullDiscountStrategy();
            }
        }
    }
}
