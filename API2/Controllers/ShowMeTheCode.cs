using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Controllers
{
    public class ShowMeTheCode : Controller
    {
        [HttpGet]
        [Route("/showmethecode")]
        public String Get()
        {
            return "https://github.com/danimarveriato/API-.NET-Core";
        }

    }
}
