using JsonConverter.Test.Api.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonConverter.Test.Api.Controllers
{
    [ApiController]
    [Route("api/numbers")]
    public class NumbersController : ControllerBase
    {
        [HttpPost]
        public NumberDto Post([FromBody] NumberDto dto)
        {
            return dto;
        }
    }
}
