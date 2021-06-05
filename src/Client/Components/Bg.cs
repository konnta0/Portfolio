using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Client.Components
{
    partial class Bg
    {
        [Parameter] public RenderFragment ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)] public IDictionary<string, object> AdditionalAttributes { get; set; }
    }
}