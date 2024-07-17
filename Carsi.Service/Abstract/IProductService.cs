using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Shared.DTOS;
using Carsi.Shared.Response;

namespace Carsi.Service.Abstract
{
    public interface IProductService
    {
        Task<Response<ProductDto>> AddAsync(AddProductDto addProductDto);
        Task<Response<List<ProductDto>>> GetAllAsync();
        Task<Response<ProductDto>> GetByIdAsync(int id);
        Task<Response<ProductDto>> UpdateAsync(EditProductDto productDto);
        Task<Response<NoContent>> DeleteAsync(int id);
        Task<Response<List<ProductDto>>> GetActiveAsync(bool IsActive=true);
        Task<Response<List<ProductDto>>>  HomeProducts ();
    }
}