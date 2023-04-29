using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components;

namespace Gitblazor.UI.Routing
{
    public static class SidebarNavigation
    {
        public static List<NavigationItem> NavigationItems = new()
        {
            new NavigationItem { Name = "Habits", Route = Routes.Home, Icon="fa-solid fa-house"},
            new NavigationItem { Name = "Repositories", Route = "/repositories", Icon="fa-regular fa-folder-open" }
        };
    }
    public record NavigationItem
    {
        public string Name { get; init; }
        public string Route { get; init; }
        public string Icon { get; init; }
    }

    public static class Routes
    {
        public const string Home = "/home";
    }
}
