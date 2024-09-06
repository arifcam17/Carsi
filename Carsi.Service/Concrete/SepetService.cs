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

        public async Task<Response<SepetDto>> GetSepetByUserId(string userId)
        {

             Sepet sepet= await   _sepetRepository.GetCartByUserIdAsync(userId);
             
             return Response<SepetDto>.Success(_mapper.Map<SepetDto>(sepet),200);
        }

        public async Task<Response<NoContent>> InitializeSepetAsync(string userId)
        {
            Sepet sepet = new Sepet{UserId=userId};
            await _sepetRepository.CreateAsync(sepet);
            return Response<NoContent>.Success(201);

        }
    }
}