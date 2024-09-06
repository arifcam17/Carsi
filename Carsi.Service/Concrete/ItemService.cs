using AutoMapper;
using Carsi.Data.Abstract;
using Carsi.Entity.Concrete;
using Carsi.Service.Abstract;
using Carsi.Shared.DTOS;
using Carsi.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsi.Service.Concrete
{
    public class ItemService : IItemService
    {

        private readonly IItemRepository _itemRepository;
        private readonly ISepetRepository _sepetRepository;
        private readonly IMapper _mapper;
        public ItemService(IItemRepository itemRepository, IMapper mapper, ISepetRepository sepetRepository)
        {
            _itemRepository = itemRepository;
            _sepetRepository=sepetRepository;
            _mapper = mapper;
        }



        public async Task<Response<NoContent>> AddAsync(AddSepetDto add)
        {
            var sepet = await _sepetRepository.GetCartByUserIdAsync(add.UserId);
            if(sepet == null)
            {
                return Response<NoContent>.Failure("HATA OLUSTU",404);
            }
            int index = sepet.Items.FindIndex(x=>x.ProductId==add.ProductId);
            if(index <0)
            {
                 sepet.Items.Add(new Item{
                    ProductId=add.ProductId,
                    SepetId=sepet.Id,
                    Adet=add.Quantity,

                 });
            }
            else
            {
                sepet.Items[index].Adet += add.Quantity;
            }
             await _sepetRepository.UpdateAsync(sepet);
             return Response<NoContent>.Success(204);
           
        }

        public async Task<Response<NoContent>> ChangeQuantityAsync(int itemId, int quantity)
        {
           Item item = await _itemRepository.GetById(itemId);
           item.Adet = quantity;
           await _itemRepository.UpdateAsync(item);
           return Response<NoContent>.Success(204);

        }

        public async Task<Response<NoContent>> ClearAsync(string userId)
        {
            Sepet sepet= await  _sepetRepository.GetCartByUserIdAsync(userId);
            sepet.Items = new List<Item>();
            await _sepetRepository.UpdateAsync(sepet);
            return Response<NoContent>.Success(204);
        }

        public async Task<Response<NoContent>> DeleteItemAsync(int itemId)
        {
           Item item = await _itemRepository.GetById(itemId);
           await _itemRepository.DeleteAsync(item);
           return Response<NoContent>.Success(200);
        }
    }
}
