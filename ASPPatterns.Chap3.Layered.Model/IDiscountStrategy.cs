namespace ASPPatterns.Chap3.Layered.Model
{
    public interface IDiscountStrategy
    {
        decimal ApplyExtraDiscountTo(decimal originalSalePrice);
    }
}
