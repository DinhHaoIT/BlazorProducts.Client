using BlazorProducts.Client.HttpRepository;
using BlazorProducts.Client.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorProducts.Client.Pages
{
    public partial class Company
    {
        public List<BlazorProducts.Client.Models.Company> CompanyList { get; set; } = new List<BlazorProducts.Client.Models.Company>();
        public MetaData MetaData { get; set; } = new MetaData();
        private CompanyParameters _companyParameters = new CompanyParameters();
        [Inject]
        public ICompanyHttpRepository CompanyRepo { get; set; }
        protected async override Task OnInitializedAsync()
        {
            var pagingResponse = await CompanyRepo.GetCompanies(_companyParameters);
            CompanyList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
    }
}
