using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace suninfo
{
    public class ApiHelper
    {
        private const string MediaType = "aplication/json";

        public static HttpClient APIclient { get; set; } 

        public static void InitializeClient()
        {
           APIclient= new HttpClient();
           // APIclient.BaseAddress = new Uri("http://xkcd.com/");
            APIclient.DefaultRequestHeaders.Accept.Clear();
            APIclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaType));
        }
    }
}
