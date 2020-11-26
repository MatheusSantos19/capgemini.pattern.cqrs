using MediatR;
using ProductsControl.Application.Command.Request;
using ProductsControl.Domain.Interfaces.ProductsRepository;
using ProductsControl.Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductsControl.Application.Command.Handler
{
    public class ProductCommandHandler : IRequestHandler<ProductsCreateCommand, string>
    {
        private readonly IProductsRepository _productRepository;

        public ProductCommandHandler(IProductsRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public Task<string> Handle(ProductsCreateCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Descriptions,request.Stock,request.FlgAtivo);
             _productRepository.Post(product);
            return Task.FromResult("Produto inserido com sucesso");
        }
    }
}
