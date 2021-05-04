using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace OpenweathermapRequestLib
{
    public class OpenweathermapRequest
    {
        private readonly JObject jObject;

        public OpenweathermapRequest(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);

            using (var twitpicResponse = (HttpWebResponse)request.GetResponse())
            {
                using (var reader = new StreamReader(twitpicResponse.GetResponseStream()))
                {
                    var objText = reader.ReadToEnd();
                    this.jObject = JObject.Parse(objText);
                }
            }
        }

        public float Longitude => ((dynamic)jObject).coord.lon;

        public float Latitude => ((dynamic)jObject).coord.lat;

        public float Temperature => ((dynamic)jObject).main.temp;
    }
}
