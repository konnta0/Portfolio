using Microsoft.AspNetCore.Components;

namespace Client.Components.Content.Sections.About.Skills
{
    public partial class SkillItem
    {
        [Parameter] public int Value { get; set; }
        [Parameter] public string Name { get; set; }
    }
}