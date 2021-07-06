using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Client.Components.Content.Sections
{
    partial class Section
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter(CaptureUnmatchedValues = true)] public IDictionary<string, object> AdditionalAttributes { get; set; }
    }
}