using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using firstAPI.Models;
using Newtonsoft.Json;

namespace firstAPI.Controllers
{
    //Route = api/Req2
    [Route("api/[controller]")]
    [ApiController]
    public class Req2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

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
            Create an API Endpoint, B, that accepts an array of integers and returns an object containing the SUM and the AVERAGE for all even numbers in the array.
            Use LINQ to implement the SUM functionality.
            The returned object should be explicitly defined in a C# class and serialized as JSON. For example, [5,6,7,8] would return {“sum”: 14, “average”: 7}
             */

            //custom class to hold SUM / AVG
            model_req2 final_result = new model_req2();

            //var test = JsonConvert.SerializeObject(payload["int_array"]);
            //var test = JsonConvert.SerializeObject(payload);
            //JObject parsed = JObject.Parse(test);

            //represents JSon info in an array
            JArray array = (JArray)payload["int_array"];

            //initializing an actual integer array for AVG / SUM calcs
            //int test = (int)array[0];
            int[] values = new int[array.Count];
            int even_counter = 0;

            //for loop to populate array w/ even integers (not sure if this is correct practice)
            for(int x = 0; x < array.Count; x++)
            {
                //values[x] = (int)array[x];
                if ((int)array[x] % 2 == 0)
                {
                    values[x] = (int)array[x];
                    even_counter++;
                }
            }

            //filling custom class with SUM and AVG values for return
            //int sum = values.Sum();
            final_result.sum = values.Sum();
            final_result.average = values.Sum() / even_counter;

            return Ok(final_result);
        }
    }
}
