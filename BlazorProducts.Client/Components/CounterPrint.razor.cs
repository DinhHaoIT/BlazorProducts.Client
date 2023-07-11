﻿using Microsoft.AspNetCore.Components;

namespace BlazorProducts.Client.Components
{
    public partial class CounterPrint
    {
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public int CurrentCount { get; set; }
        protected override void OnInitialized()
        {
            Console.WriteLine($"OnInitialized => Title: {Title}, CurrentCount: {CurrentCount}");
        }
        protected override void OnParametersSet()
        {
            Console.WriteLine($"OnParameterSet => Title: {Title}, CurrentCount: {CurrentCount}");
        }
        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                Console.WriteLine("This is the first render of the component");
            }
        }
        protected override bool ShouldRender()
        {
            return true;
        }
    }
}
