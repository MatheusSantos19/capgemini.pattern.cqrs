using MediatR;
using ProductsControl.Application.Query.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsControl.Application.Query.Request
{
    public class ProductGetRequest : IRequest<ProductGetResponse>
    {
        public int id { get; set; }
    }
}
