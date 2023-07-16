using Microsoft.AspNetCore.Components;

namespace BlazorProducts.Client.Pages
{
    public partial class CustomNotFound
    {
        [Inject]
        public NavigationManager Navigation { get; set; }
        public void NavigateToHome()
        {
            Navigation.NavigateTo("/");
        }
    }
}
