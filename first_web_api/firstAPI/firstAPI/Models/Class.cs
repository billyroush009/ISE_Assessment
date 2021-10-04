using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstAPI.Models
{
    //Create an API Endpoint, B, that accepts an array of integers and returns an object containing the SUM and the AVERAGE for all *EVEN NUMBERS* in the array.
    //Use LINQ to implement the SUM functionality.
    //The returned object should be explicitly defined in a C# class and serialized as JSON. For example, [5,6,7,8] would return {“sum”: 14, “average”: 7}
    public class model_req2
    {
        public int sum { get; set; }
        public int average { get; set; }
    }

    public class model_req3
    {
        public int[] sortedNumbers { get; set; }
        public int sum { get; set; }
        public int average { get; set; }
    }
}
