using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Service;
using Service.Interface;

namespace API.Controllers
{
    [EnableCors("AllowCors"), Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        //
        private readonly IControllerSensorService cont2;

        //
        private readonly IRoom test;
        private readonly IControllerTest testC;

        public RoomController(IControllerSensorService cont2,IRoom test, IControllerTest testC)
        {
            this.test = test;
            this.cont2 = cont2;
            this.testC = testC;

        }

        // GET: api/SensorDataVW

        [HttpGet("{room}")]
        public IActionResult Get(string room)
        {
            return  Ok(cont2.GetControllerSensorStateByRoom(room));

           // return Ok(cont2.Get());
        }

        [HttpGet]
        public IActionResult GetDS()
        {
            return Ok(test.GetDS());

           
        }

        [HttpGet("C")]
        public IActionResult GetS()
        {
            return Ok(testC.GetS());


        }
    }
}