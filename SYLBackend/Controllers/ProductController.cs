using Microsoft.AspNetCore.Mvc;
using SYLBackend.DTO.ProductDTO;
using SYLBackend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController
    {
        
       
            private readonly IProductProcessor _productProcessor;

            public ProductController(IProductProcessor productProcessor)
            {
                _productProcessor = productProcessor;
            }

            [HttpPost]
            public async Task<IActionResult> AddProduct([FromBody] NewProductDTO data)
            {
                throw new NotImplementedException();
            }

            [HttpPut]
            public async Task<IActionResult> ModifyProduct([FromBody] ModifyProductDTO data)
            {
                throw new NotImplementedException();
            }

            [HttpDelete]
            public async Task<IActionResult> DeleteProduct(string productId)
            {
                throw new NotImplementedException();
            }

            [HttpGet]
            public async Task<IActionResult> GetAllProducts()
            {
                throw new NotImplementedException();
            }

            [HttpGet]
            public async Task<IActionResult> GetProductsByQuerry(string data)
            {
                throw new NotImplementedException();
            }
        }
    
}
