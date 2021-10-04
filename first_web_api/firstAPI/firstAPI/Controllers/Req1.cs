using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstAPI.Controllers
{
    //Route = api/Req1
    [Route("api/[controller]")]
    [ApiController]
    public class Req1 : ControllerBase
    {
        //default get() for this controller, prints return value in browser
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World!");
        }

        //NewtonsoftJson NuGet Package
        //using Newtonsoft.Json.Linq;
        //using Microsoft.AspNetCore.Mvc;
        [HttpPost]
        public IActionResult Post(JObject payload)
        {
            /*
            Create an API Endpoint, A, that accepts an array of integers, and returns the array, sorted in descending order (highest to lowest).
            Use LINQ for implementing your sort. For example [6,2,87,2] will return as [87,6,2,2]
             */

            //payload["foo"] += "!!!";
            //return Ok(payload);

            //creating a list of LINQ sorted payload["int_array"] values to return
            var list = from i in payload["int_array"]
                       orderby i descending
                       select i;

            return Ok(list);
            //return Ok(payload["int_array"]);
        }
    }
}
