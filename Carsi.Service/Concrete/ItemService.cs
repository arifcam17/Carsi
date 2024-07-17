using AutoMapper;
using Carsi.Data.Abstract;
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
        private readonly IMapper _mapper;
        public ItemService(IItemRepository itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }



        public Task<Response<NoContent>> AddAsync(SepetDto add)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> ChangeQuantityAsync(int itemId, int quantity)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> ClearAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteItemAsync(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
