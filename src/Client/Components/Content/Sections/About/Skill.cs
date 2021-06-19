using Microsoft.AspNetCore.Components;

namespace Client.Components.Content.Sections.About
{
    public partial class Skill
    {
        [Parameter] public int Value { get; set; }
        [Parameter] public string Name { get; set; }
    }
}