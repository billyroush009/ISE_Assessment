using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
using System.Net.Http.Headers;


namespace Req4
{
    class Program

    {

        //private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            using (var client = new HttpClient())
            {
                //person p = new person { name = "Sourav", surname = "Kayal" };
                client.BaseAddress = new Uri("https://localhost:44394");
                //var response = client.PostAsJsonAsync("api/Req3", p).Result;

                //user input for POST
                Console.Write("Enter an array of integers as csv's with no spaces: ");
                string input_array = Console.ReadLine();

                //prepping POST statement
                HttpContent contentPost = new StringContent("{\"int_array\" : [" + input_array + "]}", Encoding.UTF8, "application/json");

                var result = client.PostAsync("https://localhost:44394/api/Req3", contentPost).Result;
                Console.WriteLine(result.Content.ReadAsStringAsync().Result);
                Console.ReadLine();

            }
        }
    }
}
