using System.Web.Routing;
using App.Routing;

namespace App
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.LowercaseUrls = true;

            routes.MapWebPageRoute(
                name: "Default",
                url: "{*url}",
                path: "~/Index.cshtml");
        }
    }
}