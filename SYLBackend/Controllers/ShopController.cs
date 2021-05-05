using Microsoft.AspNetCore.Mvc;
using SYLBackend.DTO.ShopDTO;
using SYLBackend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController
    {
        private readonly IShopProcessor _shopProcessor;

        public ShopController(IShopProcessor shopProcessor)
        {
            _shopProcessor = shopProcessor;
        }

        [HttpPost]
        public Task<IActionResult> AddNewShop([FromBody] NewShopDTO data)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public Task<IActionResult> ModifyShop([FromBody] ModifyShopDTO data)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public Task<IActionResult> DeleteShop(string productId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<IActionResult> GetAllShops()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<IActionResult> GetShopsByQuerry(string data)
        {
            throw new NotImplementedException();
        }
    }
}
