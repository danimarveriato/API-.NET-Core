using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API1.Controllers
{
    [Route("api")]
    [ApiController]
    public class JurosController : Controller
    {
        // GET api/<JurosController>/5
        [HttpGet]
        [Route("/taxaJuros")]
        public Double Get()
        {
            return 0.01;
        }
    }
}
