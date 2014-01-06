namespace ASPPatterns.Chap3.Layered.Model
{
    public class Price
    {
        private IDiscountStrategy _discountStrategy = new NullDiscountStrategy();
        private readonly decimal _rrp;
        private readonly decimal _sellingPrice;

        public Price(decimal rrp, decimal sellingPrice)
        {   
            _rrp = rrp;
            _sellingPrice = sellingPrice;
        }

        public void SetDiscountStrategyTo(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal SellingPrice
        {
            get { return _discountStrategy.ApplyExtraDiscountTo(_sellingPrice); }
        }

        public decimal Rrp
        {
            get { return _rrp; }
        }

        public decimal Discount
        {
            get
            {
                if (Rrp > SellingPrice)
                {
                    return Rrp - SellingPrice;
                }
                return 0;
            }
        }

        public decimal Savings
        {
            get
            {
                if (Rrp > SellingPrice)
                {
                    return (1 - SellingPrice);
                }
                return 0;
            }
        }
    }
}
