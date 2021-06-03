using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Client.Components
{
    public class BackgroundDesign : ComponentBase
    {
        [Parameter] public RenderFragment? ChildContent { get; set; }
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "background-design");
            builder.AddAttribute(1, "class", "background-design");
            if (AdditionalAttributes is {Count: > 0})
            {
                builder.AddMultipleAttributes(2, AdditionalAttributes);
            }
            builder.AddContent(3, ChildContent);
            builder.CloseElement();
        }
    }
}