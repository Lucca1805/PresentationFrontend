using PresentationFrontend.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PresentationFrontend.Services
{
    public class PresentationService
    {
        private readonly HttpClient _httpClient;

        public PresentationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Presentation>> GetAllPresentationsAsync()
        {  
            return await _httpClient.GetFromJsonAsync<List<Presentation>>("api/Presentation");
        }
        public async Task<Presentation> AddPresentationAsync(Presentation presentation)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Presentation", presentation);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Presentation>();
            }
            else
            {
                return null;
            }
        }
        public async Task<PresentationStatistics> GetPresentationStatisticsAsync(PresentationStatisticsQuery query)
        {
            string formattedToDate = query.ToDate.ToString("yyyy-MM-ddTHH:mm:ss");
            string formattedFromDate = query.FromDate.ToString("yyyy-MM-ddTHH:mm:ss");
            string url = $"api/Presentation/statistic?FromDate={formattedFromDate}&ToDate={formattedToDate}";
            return await _httpClient.GetFromJsonAsync<PresentationStatistics>(url);
        }
    }
}
