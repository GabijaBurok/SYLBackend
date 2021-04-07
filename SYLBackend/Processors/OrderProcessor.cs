using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SYLBackend.DTO.OrderDTO;
using SYLBackend.Interfaces;
using SYLBackend.Models;

namespace SYLBackend.Processors
{
    public class OrderProcessor : IOrderProcessor
    {
        public Task<bool> AddNewOrder(NewOrderDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOrder(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EndOrder(OrderIdDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<Orders> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Task<Orders> GetOrderByCustomer(GetCustomerOrdersDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<Orders> GetOrderByShop(GetShopOrdersDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ModifyOrder(ModifyOrderDTO data)
        {
            throw new NotImplementedException();
        }
    }
}
