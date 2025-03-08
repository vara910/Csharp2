using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1Preparation
{
    public class AsyncExamples
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine($"Fetching data...{DateTime.Now.ToString()}");
            //m1 4
            //m2
            string result = await FetchDataAsync("https://Google.com");//3

            Console.WriteLine(result);
        }
        public static async Task<string> FetchDataAsync(string url)
        {
            Console.WriteLine($"I am working {DateTime.Now.ToString()} ");
            using (HttpClient client = new HttpClient())
            {
                // The await keyword allows the method to be non-blocking
                string response = await client.GetStringAsync(url);
                Console.WriteLine("I am done");
                return response;
            }

        }

        
    }
}