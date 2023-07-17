using BlazorProducts.Client.Features;
using BlazorProducts.Client.Models;
using Microsoft.AspNetCore.WebUtilities;
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

        public async Task<PagingResponse<Company>> GetCompanies(CompanyParameters companyParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = companyParameters.PageNumber.ToString()
            };
            var response = await _client.GetAsync(QueryHelpers.AddQueryString("Companies", queryStringParam));
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var pagingResponse = new PagingResponse<Company>
            {
                Items = JsonSerializer.Deserialize<List<Company>>(content, _options),
                MetaData = JsonSerializer.Deserialize<MetaData>(response.Headers.GetValues("X-Pagination").First(), _options)
            };
            return pagingResponse;
        }
    }
}
