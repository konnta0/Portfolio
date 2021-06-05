using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Client.Components.Background
{
    partial class Dots
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter(CaptureUnmatchedValues = true)] public IDictionary<string, object> AdditionalAttributes { get; set; }

        private string StyleClass { get; }

        public Dots()
        {
            var styles = new List<string>
            {
                GetColorStyleClassName(),
                GetPositionStyleClassName()
            };
            StyleClass = string.Join(" ", styles);
        }

        private string GetColorStyleClassName()
        {
            return $"dots-color-{new Random().Next(1, 4)}";
        }

        private string GetPositionStyleClassName()
        {
            return $"dots-{new Random().Next(1, 21)}";
        }
    }
}