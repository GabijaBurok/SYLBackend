using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SYLBackend.DTO.ShopDTO;
using SYLBackend.Interfaces;
using SYLBackend.Models;

namespace SYLBackend.Processors
{
    public class ShopProcessor : IShopProcessor
    {
        public Task<bool> AddNewShop(NewShopDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteShop(ShopIdDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<Shops> GetAllShops()
        {
            throw new NotImplementedException();
        }

        public Task<Shops> GetShopsBySeller(GetShopBySellerDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ModifyShop(ModifyShopDTO data)
        {
            throw new NotImplementedException();
        }
    }
}
