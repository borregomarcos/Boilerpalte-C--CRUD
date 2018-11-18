using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace boilerplate.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class myController :  AbpController
    {
        [HttpGet]
        
        public IActionResult Get()
        {
            //var helloWorldText = L("HelloWorld");
            return Ok("from API");
            //...
        }
    }
}