using Microsoft.AspNetCore.Components;

namespace Client.Components.Content.Sections.Projects
{
    partial class ProjectItem
    {
        [Parameter] public string Title { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public string Href { get; set; }
    }
}