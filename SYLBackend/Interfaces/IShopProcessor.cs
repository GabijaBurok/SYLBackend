using SYLBackend.DTO.ShopDTO;
using SYLBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Interfaces
{
    public interface IShopProcessor
    {
        Task<bool> AddNewShop(NewShopDTO data);
        Task<bool> ModifyShop(ModifyShopDTO data);
        Task<bool> DeleteShop(ShopIdDTO data);
        Task<Shops> GetAllShops();
        Task<Shops> GetShopsBySeller(string shop);
    }
}
