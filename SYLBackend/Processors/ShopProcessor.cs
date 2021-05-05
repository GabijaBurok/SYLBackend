using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SYLBackend.Context;
using SYLBackend.DTO.ShopDTO;
using SYLBackend.Interfaces;
using SYLBackend.Models;

namespace SYLBackend.Processors
{
    public class ShopProcessor : IShopProcessor
    {
        private readonly SYLContext context;
        public ShopProcessor(SYLContext context)
        {
            this.context = context;
        }

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

        public async Task<Shops> GetShopsBySeller(string shop)
        {
            return await Task.Run(() => context.Shops.First(a => a.shopName == shop));
        }

        public Task<bool> ModifyShop(ModifyShopDTO data)
        {
            throw new NotImplementedException();
        }
    }
}
