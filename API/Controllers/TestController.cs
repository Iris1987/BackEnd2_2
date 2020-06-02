using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IControllerTest testC;

        public TestController(IControllerTest testC)
        {
            
            this.testC = testC;

        }
        [HttpGet]
        public IActionResult GetS()
        {
            return Ok(testC.GetS());


        }
    }
}