using Carsi.Shared.Response;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsi.Shared.HELPERS.Abstract
{
    public interface IImageHelper
    {
        Task<Response< string>> Upload(IFormFile file , string location);

    }
}