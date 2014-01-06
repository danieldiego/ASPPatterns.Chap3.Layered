using System.Collections.Generic;

namespace ASPPatterns.Chap3.Layered.Service
{
    public class ProductListResponse
    {
        public bool Succes { get; set; }
        public string Message { get; set; }
        public IList<ProductViewModel> Products { get; set; } 
    }
}
