using EnsekTest.Shared.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EnsekTest.Web.Services
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccountsAsync();
        Task<Account> GetAccountAsync(int accountId);
    }

    public class AccountService : IAccountService
    {
        private readonly HttpClient _httpClient;

        public AccountService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Account>> GetAccountsAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("accounts");
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Account[]>(jsonString);
            }
            else return new List<Account>();
        }

        public async Task<Account> GetAccountAsync(int accountId)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"accounts/{accountId}");
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Account>(jsonString);
            }
            else return null;
        }
    }
}
