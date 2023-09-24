//Write a C# program to perform a GET request on the route https://coderbyte.com/api/challanges/json/json-cleaning
//and then clean the object according to the following rules:
//Remove all keys that have vaues of N/A,-,or empty strings. If one of these values appears in an array, remove that single itme fromt the array. Then console log the modified object as a string.

//Example Input
//=> {"name": {"first": "Daniel", "middle":"N/A", "last":"Smith"}, "age":45}

//Example Output
//=> {"name": {"first": "Daniel", "last":"Smith"}, "age":45}



namespace CSharpAlgorithms
{

    //using System;
    //using System.Net.Http;
    //using System.Threading.Tasks;
    //using Newtonsoft.Json.Linq;

    //class Program
    //{
    //    static async Task Main(string[] args)
    //    {
    //        var httpClient = new HttpClient();
    //        var response = await httpClient.GetAsync("https://coderbyte.com/api/challenges/json/json-cleaning");

    //        var jsonString = await response.Content.ReadAsStringAsync();
    //        var jsonObject = JObject.Parse(jsonString);

    //        CleanJsonObject(jsonObject);

    //        Console.WriteLine(jsonObject.ToString());
    //    }

    //    static void CleanJsonObject(JObject jsonObject)
    //    {
    //        foreach (var property in jsonObject.Properties().ToList())
    //        {
    //            var value = property.Value;

    //            if (value.Type == JTokenType.Object)
    //            {
    //                CleanJsonObject((JObject)value);
    //            }

    //            if (value.Type == JTokenType.Array)
    //            {
    //                CleanJsonArray((JArray)value);
    //            }

    //            if (IsInvalidValue(value))
    //            {
    //                property.Remove();
    //            }
    //        }
    //    }

    //    static void CleanJsonArray(JArray jsonArray)
    //    {
    //        for (int i = jsonArray.Count - 1; i >= 0; i--)
    //        {
    //            var value = jsonArray[i];

    //            if (value.Type == JTokenType.Array)
    //            {
    //                CleanJsonArray((JArray)value);
    //            }
    //            if (value.Type == JTokenType.Object)
    //            {
    //                CleanJsonObject((JObject)value);
    //            }

    //            if (IsInvalidValue(value))
    //            {
    //                jsonArray.RemoveAt(i);
    //            }
    //        }
    //    }

    //    static bool IsInvalidValue(JToken value)
    //    {
    //        if (value.Type == JTokenType.String)
    //        {
    //            var stringValue = value.ToString();
    //            return string.IsNullOrEmpty(stringValue) || stringValue == "N/A" || stringValue == "-";
    //        }

    //        return false;
    //    }

    //}
}