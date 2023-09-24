using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace CSharpAlgorithms
{

    //Write a C# program to perform a GET request on the route https://coderbyte.com/api/challanges/json/age-counting
    //which contains a data key and the value is a string which contains items in the format: 
    //key=STRING, age=INTEGER.Your goal is to check all keys and value pairs where the age is equal to or greater than 50.
    //Then return the count where the condition is holds in the JSON object and append the string "pa64tqg12" to count.

    //Example Input
    //=> {"data": "key=IAfpk, age=2, key=WNVdi, age=91, key=jp9zt, age=67, key=jp9zt, age=1"}

    // Example Output
    // => 2pa64tqg12

    public static class AgeCount
    {

        static async Task Main(string[] args)
        {
            var url = "https://coderbyte.com/api/challanges/json/age-counting";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();     //ensure that the response read the remote file
            var responseString = await response.Content.ReadAsStringAsync();
            var json = JObject.Parse(responseString);
            await CleanJsonObject(json);
        }

        public static async Task<string> CleanJsonObject(JObject json)
        {
            string data = json["data"].ToString();
            int count = 0;

            foreach(var item in data.Split(','))
            {
                var innerPair = item.Split('=');

                if (innerPair[0].Trim() == "age" && int.Parse(innerPair[1].Trim()) >= 50)
                    count++;
            }

            var countToSting = count.ToString() + "pa64tqg12";

            return countToSting;
        }
    }
}
