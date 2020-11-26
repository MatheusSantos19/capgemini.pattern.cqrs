using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsControl.Application.Command.Request
{
    public class ProductsCreateCommand : IRequest <string>
    {
     
        public string Descriptions { get; set; }
        public float Stock { get; set; }
        public string FlgAtivo { get; set; }

    }
}
