using Microsoft.AspNetCore.Mvc;
using SYLBackend.DTO.OrderDTO;
using SYLBackend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderProcessor _orderProcessor;

        public OrderController(IOrderProcessor orderProcessor)
        {
            _orderProcessor = orderProcessor;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewOrder([FromBody] NewOrderDTO data)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<IActionResult> ModifyOrder([FromBody] ModifyOrderDTO data)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOrder(string orderId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public async Task<IActionResult> GetOrderByCustomer(string data)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderByShop(string data)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<IActionResult> EndOrder(string data)
        {
            throw new NotImplementedException();
        }
    }
}
