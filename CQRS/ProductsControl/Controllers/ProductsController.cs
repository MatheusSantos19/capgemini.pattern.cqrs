using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsControl.Application.Command.Request;
using ProductsControl.Application.Query.Request;

namespace ProductsControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator productApplication)
        {
            _mediator = productApplication;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {

                var request = new ProductGetRequest() { id = id };
                return Ok(_mediator.Send(request));
            }
            catch (Exception ex)
            {
                return BadRequest("Falha ao localizar Produtos" + ex.ToString());

            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProductsCreateCommand command)
        {
            try
            {
                return Created("api/Products", _mediator.Send(command));
            }
            catch (Exception ex)
            {
                return BadRequest("Falha ao cadastrar Produto" + ex.ToString());
            }
        }
    }
}
