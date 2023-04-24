using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components;

namespace Gitblazor.UI.Routing
{
    public static class SidebarNavigation
    {
        public static List<NavigationItem> NavigationItems = new()
        {
            new NavigationItem { Name = "Habits", Route = "/home", Icon="fa-regular fa-star"},
            new NavigationItem { Name = "ToDo", Route = "/counter", Icon="fa-solid fa-list-check" }
        };
    }
    public record NavigationItem
    {
        public string Name { get; init; }
        public string Route { get; init; }
        public string Icon { get; init; }
    }
}
