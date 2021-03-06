﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrameData_WebApp
{
    public class APICalls
    {
        private const string uri = "http://localhost:50151/characterList";
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<string>> GetCharacterListAsync()
        {
            List<string> result = null;
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsAsync<List<string>>();
            }
            return result;
        }
    }
}
