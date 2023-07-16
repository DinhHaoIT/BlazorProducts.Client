using BlazorProducts.Client.Models;

namespace BlazorProducts.Client.HttpRepository
{
    public interface ICompanyHttpRepository
    {
        Task<List<Company>> GetCompanies();
    }
}
