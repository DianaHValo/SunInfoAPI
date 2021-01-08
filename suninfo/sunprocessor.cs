using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace suninfo
{
    public class SunProcessor
    {
        public static async Task<SunModel> LoadSunInfo(string country)
        {
            string latlng="";

            switch (country)
            {
                case "Romania": 
                    latlng = "lat=44.4268&lng=26.1025";
                    break;

                case "France":
                    latlng = "lat=46.2276&lng=2.2137";
                    break;

                case "Mexico":
                    latlng = "lat=23.6345&lng=102.5528";
                    break;
            }
            string url =String.Format("https://api.sunrise-sunset.org/json?{0}&date=today",latlng);

            using (HttpResponseMessage response=await ApiHelper.APIclient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    SunResultModel result = await response.Content.ReadAsAsync<SunResultModel>();
                    return result.Results;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        
        }
    }
}
