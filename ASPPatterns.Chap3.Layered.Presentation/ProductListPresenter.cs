using ASPPatterns.Chap3.Layered.Service;

namespace ASPPatterns.Chap3.Layered.Presentation
{
    public class ProductListPresenter
    {
        private readonly IProductListView _productListView;
        private readonly ProductService _productService;

        public ProductListPresenter(IProductListView productListView, 
            ProductService productService)
        {
            _productService = productService;
            _productListView = productListView;
        }

        public void Display()
        {
            var productListRequest = new ProductListRequest
            {
                CustomerType = _productListView.CustomerType
            };

            ProductListResponse productResponse = _productService.GetAllProductsFor(productListRequest);

            if (productResponse.Succes)
            {
                _productListView.Display(productResponse.Products);
            }
            else
            {
                _productListView.ErrorMessage = productResponse.Message;
            }
        }
    }
}
