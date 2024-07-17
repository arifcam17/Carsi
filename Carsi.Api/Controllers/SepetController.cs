using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Carsi.Service.Abstract;
using Carsi.Shared.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Carsi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SepetController : ControllerBase
    {
        private readonly ISepetService _sepetService;
        public SepetController(ISepetService sepetService)
        {
            _sepetService= sepetService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSepet(int  userId)
        {
            var response = await _sepetService.GetSepetByUserId(userId);
            return Ok(response);
        }


    }
}