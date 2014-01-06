using System.Collections.Generic;
using ASPPatterns.Chap3.Layered.Service;

namespace ASPPatterns.Chap3.Layered.Presentation
{
    public interface IProductListView
    {
        void Display(IList<ProductViewModel> products);
        Model.CustomerType CustomerType { get; }
        string ErrorMessage { set; }
    }
}
