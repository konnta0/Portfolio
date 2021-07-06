using Microsoft.AspNetCore.Components;

namespace Client.Components.Content.Sections.About.Profiles
{
    public partial class ProfileItem
    {
        [Parameter] public string Title { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}