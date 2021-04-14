using SYLBackend.DTO.OrderDTO;
using SYLBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Interfaces
{
    public interface IOrderProcessor
    {
        Task<bool> AddNewOrder(NewOrderDTO data);
        Task<bool> DeleteOrder(string orderId);
        Task<bool> ModifyOrder(ModifyOrderDTO data);
        Task<Orders> GetAllOrders();
        Task<Orders> GetOrderByCustomer(GetCustomerOrdersDTO data);
        Task<Orders> GetOrderByShop(GetShopOrdersDTO data);
        Task<bool> EndOrder(OrderIdDTO data);
    }
}
