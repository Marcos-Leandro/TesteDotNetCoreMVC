using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TesteDotNetCoreMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoAPIController : ControllerBase
    {
        [HttpGet("{id}")]
        public int Get(int id)
        {
            return id;
        }

        public IActionResult Get()
        {
            HttpContext.Response.Headers.Add("ResponseHeader", "Dados Response");

            HttpContext.Response.StatusCode = 202;

            return Content(HttpContext.Request.Path);
        }
    }
}