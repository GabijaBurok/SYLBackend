using SYLBackend.DTO.ProductDTO;
using SYLBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Interfaces
{
    interface IProductProcessor
    {
        Task<bool> AddNewProduct(NewProductDTO data);
        Task<bool> ModifyProduct(ModifyProductDTO data);
        Task<bool> DeleteProduct(ProductIdDTO data);
        Task<Products> GetAllProducts();
        Task<Products> GetProductByQuery(GetProductsByQuerryDTO data);
    }
}
