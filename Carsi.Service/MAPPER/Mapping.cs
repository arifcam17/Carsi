using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Carsi.Entity;
using Carsi.Entity.Concrete;
using Carsi.Shared.DTOS;

namespace Carsi.Service.MAPPER
{
    public class Mapping:Profile
    {
       public Mapping()
       {
        CreateMap<Product,ProductDto>().ReverseMap();
        CreateMap<Product,AddProductDto>().ReverseMap();
        CreateMap<Product,EditProductDto>().ReverseMap();

        CreateMap<User,UserDto>().ReverseMap();
        CreateMap<User,AddUserDto>().ReverseMap();
        CreateMap<User, EditUserDto>().ReverseMap();

        CreateMap<Sepet,SepetDto>().ReverseMap();
        CreateMap<Sepet,AddSepetDto>().ReverseMap();

        CreateMap<Item,ItemDto>().ReverseMap();
        
       
       
        CreateMap<Order,OrderDto>().ReverseMap();

        CreateMap<OrderItem,OrderItemDto>().ReverseMap();
        

       }   
    }
}