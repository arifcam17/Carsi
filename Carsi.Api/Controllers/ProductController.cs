using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Carsi.Service.Abstract;
using Carsi.Shared.DTOS;
using Carsi.Shared.HELPERS.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Carsi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;
        private readonly IImageHelper _imageHelper;

        public ProductController(IProductService productService , IImageHelper imageHelper)
        {
            _productService=productService;
            _imageHelper=imageHelper;
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductDto addProductDto)
        {
            var response =await _productService.AddAsync(addProductDto);
            if (response.Succeed==false)
            {
              return NotFound (JsonSerializer.Serialize(response));
            } 
            return Ok(JsonSerializer.Serialize(response));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _productService.DeleteAsync(id);
            if (response==null){
                return NotFound (response);
            }
            return Ok(response);

        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await _productService.GetAllAsync();
            if (response.Succeed==false){
                return NotFound(JsonSerializer.Serialize (response));
            }
            return Ok(JsonSerializer.Serialize (response));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _productService.GetByIdAsync(id);
            return Ok(response);
        }

        [HttpGet("active/{isActive}")]
        public async Task<IActionResult> GetActiveProducts(bool isActive)
        {
            var response = await _productService.GetActiveAsync(isActive);
            return Ok(response);
        }
       

       [HttpGet("homeproducts")]
        public async Task<IActionResult> HomeProducts()
        {
           var response = await _productService.HomeProducts();
           return Ok(JsonSerializer.Serialize(response)); 
        }

       [HttpPut]

       public async Task<IActionResult> UpdateProduct(EditProductDto editProductDto)
       {
          var response= await _productService.UpdateAsync(editProductDto);
          return Ok (response);
       }

       [HttpPost("addimage")]
       public async Task<IActionResult> ImageUpload(IFormFile file)
       {
              var response  = await _imageHelper.Upload(file , "products");
              return    Ok(response); 
       }

    }
}