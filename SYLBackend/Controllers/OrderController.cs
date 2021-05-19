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
        public Task<IActionResult> AddNewOrder([FromBody] NewOrderDTO data)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public Task<IActionResult> ModifyOrder([FromBody] ModifyOrderDTO data)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public Task<IActionResult> DeleteOrder(string orderId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<IActionResult> GetAllOrders()
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public Task<IActionResult> GetOrderByCustomer(string data)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<IActionResult> GetOrderByShop(string data)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public Task<IActionResult> EndOrder(string data)
        {
            throw new NotImplementedException();
        }
    }
}
