using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Shared.DTOS;
using Carsi.Shared.Response;

namespace Carsi.Service.Abstract
{
    public interface ISepetService
    {
        

        Task<Response<SepetDto>> GetSepetByUserId(string userId);

        //kisiye ozelsepet
         Task<Response<NoContent>> InitializeSepetAsync(string userId);
        
    }
}