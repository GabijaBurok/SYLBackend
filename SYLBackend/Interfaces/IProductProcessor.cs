using SYLBackend.DTO.ProductDTO;
using SYLBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYLBackend.Interfaces
{
    public interface IProductProcessor
    {
        Task<bool> AddNewProduct(NewProductDTO data);
        Task<bool> ModifyProduct(ModifyProductDTO data);
        Task<bool> DeleteProduct(string data);
        Task<Products> GetAllProducts();
        Task<Products> GetProductByQuery(string data);
    }
}
