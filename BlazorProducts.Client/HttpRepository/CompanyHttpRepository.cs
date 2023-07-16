using BlazorProducts.Client.Models;
using System.Text.Json;

namespace BlazorProducts.Client.HttpRepository
{
    public class CompanyHttpRepository : ICompanyHttpRepository
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
        public CompanyHttpRepository(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task<List<Company>> GetCompanies()
        {
            var response = await _client.GetAsync("Companies");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var companies = JsonSerializer.Deserialize<List<Company>>(content, _options);
            return companies;
        }
    }
}
