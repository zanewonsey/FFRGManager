using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CommonUtil.Settings
{
    public static class HttpMgr
    {
        public static T GetObject<T>(string url)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();
            string responseBody = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        public static async void PostObject<T>(T obj, string url)
        {
            HttpClient client = new HttpClient();
            string json = JsonConvert.SerializeObject(obj);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage postRequest = await client.PostAsync(url, content);
        }

        public static async void PutObject<T>(T obj, string url)
        {
            HttpClient client = new HttpClient();
            string json = JsonConvert.SerializeObject(obj);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage putRequest = await client.PutAsync(url, content);
        }

        public static async void DeleteObject<T>(T obj, string url)
        {
            HttpClient client = new HttpClient();
            string json = JsonConvert.SerializeObject(obj);
            HttpRequestMessage deleteRequest = new HttpRequestMessage
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url)
            };
            await client.SendAsync(deleteRequest);
        }
    }
}
