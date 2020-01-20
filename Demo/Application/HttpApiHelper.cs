using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class HttpApiHelper
    {
        static readonly HttpClient client = new HttpClient() {
            // BaseAddress = new Uri("http://diarytest.free-http.svipss.top/")
            BaseAddress = new Uri("http://localhost:5000/")
        };
        public static T Get<T>(string uri)
        {
            var task = client.GetAsync(uri);
            var result = task.Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(
                result.Content.ReadAsStringAsync().Result);
        }

        public static TResult Post<TResult>(
            string uri, object argument)
        {
            var cont = new StringContent(
                Newtonsoft.Json.JsonConvert.SerializeObject(argument));
            cont.Headers.ContentType = 
                new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var task = client.PostAsync(uri, cont);
            var result = task.Result;

            return Newtonsoft.Json.JsonConvert.DeserializeObject<TResult>(
                result.Content.ReadAsStringAsync().Result);
        }
    }
}