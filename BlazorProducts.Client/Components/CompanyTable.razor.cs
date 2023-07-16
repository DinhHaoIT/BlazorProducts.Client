using BlazorProducts.Client.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorProducts.Client.Components
{
    public partial class CompanyTable
    {
        [Parameter]
        public List<Company> Companies { get; set; }
    }
}
