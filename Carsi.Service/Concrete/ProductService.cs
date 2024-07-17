using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Carsi.Data.Abstract;
using Carsi.Data.Concrete;
using Carsi.Entity.Concrete;
using Carsi.Service.Abstract;
using Carsi.Shared.DTOS;
using Carsi.Shared.Response;

namespace Carsi.Service.Concrete
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository= productRepository;
            _mapper= mapper;
        }
        
        public async Task<Response<ProductDto>> AddAsync(AddProductDto addProductDto)
        {
            var product = _mapper.Map<Product>(addProductDto);
            var createdBook= await _productRepository.CreateAsync(product);
           
           if(createdBook==null)
            {
            return Response<ProductDto>.Failure("bir sorun olustu",404);
            }

            var productDto= _mapper.Map<ProductDto>(createdBook);
            return Response<ProductDto>.Success(productDto,201);
           
        }

        public async Task<Response<NoContent>> DeleteAsync(int id)
        {
            var product = await  _productRepository.GetById(id);
             if(product==null){
                return Response<NoContent>.Failure("urun bulunamadi",404);
             }
            await _productRepository.DeleteAsync(product);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<List<ProductDto>>> GetActiveAsync(bool IsActive = true)
        {
            List<Product> activeProducts  =await _productRepository.GetActiveProductsAsync(IsActive);
            var activeProductsDto = _mapper.Map <List<ProductDto>>(activeProducts);
             if(activeProductsDto==null){
                return Response<List<ProductDto>>.Failure("aktif urun bulunamadi",404);
             }
             return Response<List<ProductDto>>.Success(activeProductsDto,200);
        }

        public async Task<Response<List<ProductDto>>> GetAllAsync()
        {
            var products= await _productRepository.GetAllAsync();
            if(products.Count==0){
                return Response<List<ProductDto>>.Failure("urun bulunamadi",404);
            }
             var productDto =   _mapper.Map <List<ProductDto>>(products);
             return Response<List<ProductDto>>.Success(productDto,200);

        }

        public async Task<Response<ProductDto>> GetByIdAsync(int id)
        {
           var product= await _productRepository.GetById(id);
           if(product==null){
            return Response<ProductDto>.Failure("urun bulunamadi",0);
           }

            ProductDto productById= _mapper.Map<ProductDto>(product);
            return Response<ProductDto>.Success(productById,200);

        }

        public async Task<Response<List<ProductDto>>> HomeProducts()
        {
           var products = await  _productRepository.GetHomeProducts();
           if(products.Count==0){
            return Response<List<ProductDto>>.Failure("urun bulunamadi",0);
           }
            List<ProductDto> homeDto = _mapper.Map<List<ProductDto>>(products);
            return Response<List<ProductDto>>.Success(homeDto,200);
        }

        public async Task<Response<ProductDto>> UpdateAsync(EditProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
             
             if(product==null){
                return Response<ProductDto>.Failure("urun bulunamadi",404);
             }
             product.ModifiedDate = DateTime.Now;
             var updatedProduct= await  _productRepository.UpdateAsync(product);
             var result = _mapper.Map<ProductDto>(updatedProduct);
             return Response<ProductDto>.Success(result,200);

        }
    }
}