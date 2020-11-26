using MediatR;
using ProductsControl.Application.Query.Request;
using ProductsControl.Application.Query.Response;
using ProductsControl.Domain.Interfaces.ProductsRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductsControl.Application.Query.Handler
{
    public class ProductQueryHandler : IRequestHandler<ProductGetRequest, ProductGetResponse>
    {
        private readonly IProductsRepository _productRepository;

        public ProductQueryHandler(IProductsRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductGetResponse> Handle(ProductGetRequest request, CancellationToken cancellationToken)
        {
            var product = _productRepository.Get(request.id);
            var products = new ProductGetResponse() { Descriptions = product.Descriptions, Stock = product.Stock, FlgAtivo = product.FlgAtivo };
            return products;
        }
    }
}
