using System;
using System.Net.Http;
using System.Threading.Tasks;
using Swapi.Data.Contracts;

namespace Swapi.Data.Helpers
{
    public class HttpHelper : IHttpHelper
    {
        private readonly string _baseUrl;
        public HttpHelper(string baseUrl)
        {
            _baseUrl = baseUrl;
        }   

        public async Task<string> GetJsonResponse(string entity ,int id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_baseUrl);
                    var response = await client.GetAsync($"{entity}/{id}");
                    var responseString = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        return responseString;
                    }
                }
                return string.Empty;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
