using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace THBWebsite.Components.Layout
{
    public partial class TopNavMenu
    {
        [Parameter]
        public string BackgroundImageClassName { get; set; }


        //     [Inject]
        //     public NavigationManager NavigationManager {get; set;} = default(NavigationManager)!;
        //     
        //     public  string     CurrentPageTopNavClassName { get; private set; } = "top-nav-menu-button-current";
        //     public  string     NotCurrentPageTopNavClassName { get; private set; } = "top-nav-menu-button";
        //     private List<Link> _links = new List<Link>();
        //     
        //     
        //     private bool _isCurrentPage = false;
        //
        //     public string GetClassName()
        //     {
        //         foreach (Link link in _links)
        //         {
        //             if (NavigationManager.ToAbsoluteUri(link.RelativeUri).AbsoluteUri == NavigationManager.Uri)
        //             {
        //                 return CurrentPageTopNavClassName;
        //             }
        //
        //             return NotCurrentPageTopNavClassName;
        //         }
        //
        //         return NotCurrentPageTopNavClassName;
        //     }
        //
        //     public TopNavMenu()
        //     {
        //         Link[] links = new Link[]
        //         {
        //             new Link("/home"),
        //             new Link("/about-us"),
        //             new Link("/epk"),
        //             new Link("/shop"),
        //         };
        //         
        //         _links.AddRange(links);
        //     }
    }
    //
    // public class Link
    // {
    //     public string RelativeUri { get; private set; }
    //
    //     public Link(string relativeUri)
    //     {
    //         RelativeUri = relativeUri;
    //     }
    // }
    
    
}