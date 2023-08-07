using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CSharpAlgorithms
{
    //Write a C# program to perform a GET request on the route https://coderbyte.com/api/challanges/json/age-counting
    //which contains a data key and the value is a string which contains items in the format: 
    //key=STRING, age=INTEGER.Your goal is to remove all keys and value pairs where the age is equal to 1. Then return the number of keys in the newly modified JSON object.

    //Example Input
    //=> {"data": "key=IAfpk, age=2, key=WNVdi, age=1, key=jp9zt, age=47, key=jp9zt, age=1"}

    // Example Output
    // => 2


    public class AgeCount2
    {
        static async Task Main(string[] args)
        {
            using (var httpClient = new HttpClient())
            {
                string url = "https://coderbyte.com/api/challenges/json/age-counting";
                var response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string jsonString = await response.Content.ReadAsStringAsync();
                JObject jsonObject = JObject.Parse(jsonString);

                Console.WriteLine($"Count of Age not Equal to 1: " + ExtractJsonObject(jsonObject));
            }
        }

        static string ExtractJsonObject(JObject jsonObject)
        {
            int count = 0;
            string data = jsonObject["data"].ToString();
            foreach (var item in data.Split(','))
            {
                string[] inerString = item.Split("=");

                if (inerString[0].Trim() == "age" && inerString[1].Trim() == "1")
                    data.Remove(data.IndexOf(item), item.Length);

                if (inerString[0].Trim() == "age" && inerString[1] != "1")
                    count++;
            }

            return count.ToString();
        }

    }
}
