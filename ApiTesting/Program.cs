using System.Collections.Generic;
using RestSharp;
using ApiTesting.Models;

namespace ApiTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new RestClient("https://api.github.com");
            var request = new RestRequest("users/Mak0/followers");
            var user = client.Get<List<User>>(request).Data;
        }
    }
}