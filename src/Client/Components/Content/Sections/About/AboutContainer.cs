using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Client.Components.Content.Sections.About
{
    partial class AboutContainer
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter(CaptureUnmatchedValues = true)] public IDictionary<string, object> AdditionalAttributes { get; set; }
    }
}