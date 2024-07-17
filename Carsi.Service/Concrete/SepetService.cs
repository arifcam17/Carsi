using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Carsi.Data.Abstract;
using Carsi.Entity.Concrete;
using Carsi.Service.Abstract;
using Carsi.Shared.DTOS;
using Carsi.Shared.Response;

namespace Carsi.Service.Concrete
{
    public class SepetService : ISepetService
    {

        private readonly ISepetRepository _sepetRepository;
        private readonly IMapper _mapper;
        public SepetService(ISepetRepository sepetRepository, IMapper mapper)
        { 
            _sepetRepository =sepetRepository;
            _mapper=mapper;  
        }

        public async Task<Response<SepetDto>> GetSepetByUserId(int userId)
        {

             Sepet sepet= new Sepet{UserId=userId};
             var createdsepet = await  _sepetRepository.GetCartByUserIdAsync(userId);
             var createdsepetDto = _mapper.Map<SepetDto>(createdsepet);
             return Response<SepetDto>.Success(createdsepetDto,200);
        }

        public Task<Response<NoContent>> InitializeSepetAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}