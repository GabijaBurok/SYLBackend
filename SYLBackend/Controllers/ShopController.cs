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
        public async Task<IActionResult> AddNewShop([FromBody] NewShopDTO data)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<IActionResult> ModifyShop([FromBody] ModifyShopDTO data)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteShop(string productId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllShops()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetShopsByQuerry(string data)
        {
            throw new NotImplementedException();
        }
    }
}
