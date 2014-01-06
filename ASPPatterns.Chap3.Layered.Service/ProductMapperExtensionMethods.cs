using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPPatterns.Chap3.Layered.Service
{
    public static class ProductMapperExtensionMethods
    {
        public static IList<ProductViewModel> ConvertToProductListViewModel(this IList<Model.Product> products)
        {
            return products.Select(product => product.ConvertToProductViewModel()).ToList();
        }

        public static ProductViewModel ConvertToProductViewModel(this Model.Product product)
        {
            var productViewModel = new ProductViewModel
            {
                ProductId = product.Id,
                Name = product.Name,
                Rrp = String.Format("{0:C}", product.Price.SellingPrice),
                SellingPrice = String.Format("{0:C}", product.Price.SellingPrice)
            };

            if (product.Price.Discount > 0)
            {
                productViewModel.Discount = String.Format("{0:C}", product.Price.Discount);
            }

            if (product.Price.Savings < 1 && product.Price.Savings > 0)
            {
                productViewModel.Savings = product.Price.Savings.ToString("#%");
            }

            return productViewModel;
        }
    }
}
