using BlazorProducts.Client.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorProducts.Client.Components
{
    public partial class Pagination
    {
        [Parameter]
        public MetaData MetaData { get; set; }
        [Parameter]
        public int Spread { get; set; }
        [Parameter]
        public EventCallback<int> SelectedPage { get; set; }
    }
}
