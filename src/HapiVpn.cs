using System.Net.Http;
using System.Net.Http.Headers;

namespace HapiVpnApi
{
    public class HapiVpn
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://demo.hapivpn.com/api";
        
        public HapiVpn()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Dart/2.19 (dart:io)");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetAppSettings()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/app-settings");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAppCategories()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/categories/app");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAppContacts()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/settings");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetBanner()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/banner");
            return await response.Content.ReadAsStringAsync();
        }
        
        public async Task<string> GetPolling()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/polling");
            return await response.Content.ReadAsStringAsync();
        }
        
        public async Task<string> GetServers()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/vpn-module");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
