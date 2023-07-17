using BlazorProducts.Client.Features;
using BlazorProducts.Client.Models;

namespace BlazorProducts.Client.HttpRepository
{
    public interface ICompanyHttpRepository
    {
        Task<PagingResponse<Company>> GetCompanies(CompanyParameters companyParameters);
    }
}
