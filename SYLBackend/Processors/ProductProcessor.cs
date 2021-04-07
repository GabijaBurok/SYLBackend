using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SYLBackend.DTO.ProductDTO;
using SYLBackend.Interfaces;
using SYLBackend.Models;

namespace SYLBackend.Processors
{
    public class ProductProcessor : IProductProcessor
    {
        public Task<bool> AddNewProduct(NewProductDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(ProductIdDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<Products> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Products> GetProductByQuery(GetProductsByQuerryDTO data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ModifyProduct(ModifyProductDTO data)
        {
            throw new NotImplementedException();
        }
    }
}
