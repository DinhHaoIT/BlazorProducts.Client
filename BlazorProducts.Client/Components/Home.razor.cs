using Microsoft.AspNetCore.Components;
using System.Xml.Linq;

namespace BlazorProducts.Client.Components
{
    public partial class Home
    {
        [Parameter]
        public string? Title { get; set; }
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> AdditionalAttributes { get; set; }

        [CascadingParameter(Name = "HeadingColor")]
        public string Color { get; set; }

        //Đối với RenderFragment thì tên phải đặt là ChildContent
        //hoặc phải chỉ ra tường mình ở lớp cha
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        public override Task SetParametersAsync(ParameterView parameters)
        {
            return base.SetParametersAsync(parameters);
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}
