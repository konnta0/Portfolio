using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Client.Components
{
    public class BlurDots : ComponentBase
    {
        public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "blur-dots");
            // builder.AddAttribute(1, "width", "20vmin");
            // builder.AddAttribute(2, "height", "20vmin");
            // builder.AddAttribute(3, "border-radius", "20vmin");
            // builder.AddAttribute(4, "backface-visibility", "hidden");
            // builder.AddAttribute(5, "position", "absolute");
            // builder.AddAttribute(6, "animation-name", "move");
            // builder.AddAttribute(7, "animation-duration", "6s");
            // builder.AddAttribute(8, "animation-timing-function", "linear");
            // builder.AddAttribute(9, "animation-iteration-count", "infinite");
            builder.AddAttribute(1, "class", "blur-dots");
            if (AdditionalAttributes is {Count: > 0})
            {
                builder.AddMultipleAttributes(10, AdditionalAttributes);
            }
            builder.CloseElement();
            
        }        
    }
}