using System;

namespace ASPPatterns.Chap3.Layered.Service
{
    public class ProductService
    {
        private readonly Model.ProductService _productService;

        public ProductService(Model.ProductService productService)
        {
            _productService = productService;
        }

        public ProductListResponse GetAllProductsFor(ProductListRequest productListRequest)
        {
            var productListResponse = new ProductListResponse();

            try
            {
                var productEntities = _productService.GetAllProductsFor(productListRequest.CustomerType);
                productListResponse.Products = productEntities.ConvertToProductListViewModel();
                productListResponse.Succes = true;
            }
            catch (Exception)
            {
                //Log the exception
                productListResponse.Succes = false;
                //Return a friendly error message
                productListResponse.Message = "An error ocurred.";
            }

            return productListResponse;
        }
    }
}
