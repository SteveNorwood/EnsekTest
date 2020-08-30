using EnsekTest.Shared.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EnsekTest.Web.Services
{
    public interface IMeterReadingService
    {
        Task<IEnumerable<MeterReading>> GetMeterReadingsAsync();
    }
    public class MeterReadingService : IMeterReadingService
    {
        private readonly HttpClient _httpClient;

        public MeterReadingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<MeterReading>> GetMeterReadingsAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("meterreadings");
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<MeterReading[]>(jsonString);
            }
            else return new List<MeterReading>();
        }
    }
}
