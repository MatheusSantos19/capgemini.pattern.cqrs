using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsControl.Application.Query.Response
{
    public class ProductGetResponse
    {
        public string Descriptions { get; set; }
        public float Stock { get; set; }
        public string FlgAtivo { get; set; }
    }
}
