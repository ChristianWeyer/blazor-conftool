using BlazorAppConfTool.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorAppConfTool.Services
{
    public class ConferencesService
    {
        private HttpClient _httpClient;
        private string _conferencesUrl = "https://api-ttconftool.azurewebsites.net/api/v1/conferences";

        public ConferencesService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<ConferencesResponse> GetConferences()
        {
            var result = await this._httpClient.GetJsonAsync<ConferencesResponse>(_conferencesUrl);

            return result;
        }
    }
}
