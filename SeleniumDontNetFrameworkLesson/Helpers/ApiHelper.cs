using Newtonsoft.Json;
using OpenQA.Selenium.DevTools.V121.CSS;
using SeleniumDontNetFrameworkLesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SeleniumDontNetFrameworkLesson.Helpers
{
    public class ApiHelper
    {

        //async Method A ()

        //Method B ()



        public static async Task GetRequest()
        {
            var apiUrl = "https://localhost:44389/WeatherForecast"; //"https://jsonplaceholder.typicode.com/todos/1";

            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(apiUrl);

                    if(response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();

                        var todos = DeserializeJson<Todos>(content);
                      
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        public static async Task TestPostRequest()
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts";

            var postObject = new Todos
            {
                Completed = true,
                Id = 101,
                Title = "test",
                UserId = 101
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Convert the post object to JSON
                    var jsonPayload = JsonSerializer.Serialize(postObject);

                    // Create a StringContent with the JSON payload
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    // Send the POST request
                    var response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("API Response:");
                        Console.WriteLine(jsonResponse);
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }


        static T DeserializeJson<T>(string json) 
        {
           return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
