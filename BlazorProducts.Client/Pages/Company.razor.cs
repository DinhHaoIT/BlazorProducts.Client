using BlazorProducts.Client.HttpRepository;
using Microsoft.AspNetCore.Components;

namespace BlazorProducts.Client.Pages
{
    public partial class Company
    {
        public List<BlazorProducts.Client.Models.Company> CompanyList { get; set; } = new List<BlazorProducts.Client.Models.Company>();
        [Inject]
        public ICompanyHttpRepository CompanyRepo { get; set; }
        protected async override Task OnInitializedAsync()
        {
            CompanyList = await CompanyRepo.GetCompanies();
            //just for testing
            foreach (var product in CompanyList)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
