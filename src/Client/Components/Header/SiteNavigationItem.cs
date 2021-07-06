using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Client.Components.Header
{
    public partial class SiteNavigationItem
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter(CaptureUnmatchedValues = true)] public IDictionary<string, object> AdditionalAttributes { get; set; }
        [Parameter] public string Href { get; set; }
    }
}