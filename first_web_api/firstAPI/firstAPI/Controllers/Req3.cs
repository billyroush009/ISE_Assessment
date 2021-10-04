using firstAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;



namespace firstAPI.Controllers
{

    //Route = api/Req3
    [Route("api/[controller]")]
    [ApiController]
    public class Req3 : Controller
    {
        //miracle function to pull POST results from outside controllers
        public string sendPostRequest(string URI, dynamic content)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44394");

            var valuesAsJson = JsonConvert.SerializeObject(content);
            HttpContent contentPost = new StringContent(valuesAsJson, Encoding.UTF8, "application/json");

            var result = client.PostAsync(URI, contentPost).Result;
            return result.Content.ReadAsStringAsync().Result;
        }

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
            Create an API Endpoint, C, that accepts an array of integers,
            then sorts the array using Endpoint A, and retrieves the sum & average using Endpoint B.
            The resulting response object should be explicitly defined in a C# class which contains an array of SortedNumbers,
            an integer representing the evenSum, and an integer representing the evenAvg.
             */

            //custom class to hold sortedNumbers, sum, avg
            model_req3 final_result = new model_req3();

            var req1_results = sendPostRequest("https://localhost:44394/api/Req1", payload);
            //splitting results because I am struggling with JSon data-types
            char[] charsToTrim = { '"', '[', ',', ']', ' ', '{', '}', '\\', ':'};
            string[] req1_stringArr = req1_results.Split(charsToTrim);
            //removing empty elements
            req1_stringArr = req1_stringArr.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            //converting to int arr
            int[] req1_intArr = Array.ConvertAll(req1_stringArr, s => int.Parse(s));
            final_result.sortedNumbers = req1_intArr;
            
            var req2_results = sendPostRequest("https://localhost:44394/api/Req2", payload);
            //hackish splitting to get results because I'm running out of time!
            string[] req2_stringArr = req2_results.Split(charsToTrim);
            final_result.sum = Int32.Parse(req2_stringArr[4]);
            final_result.average = Int32.Parse(req2_stringArr[8]);


            //var req1_results = RedirectToAction("Post", "api/Req1", payload);

            return Ok(final_result);
        }

    }
}
