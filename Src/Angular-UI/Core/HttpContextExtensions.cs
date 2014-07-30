using System.Web;
using System.Web.Routing;

namespace App
{
    public static class HttpContextExtensions
    {
        private const string RouteKey = "__Route";

        internal static void SetRouteValue(this HttpContextBase context, RouteValueDictionary route)
        {
            context.Items[RouteKey] = route;
        }

        internal static string GetRouteValue(this HttpContextBase context, string key)
        {
            var route = context.Items[RouteKey] as RouteValueDictionary;

            if (route != null)
            {
                var routeValue = route[key];
                return routeValue != null ? routeValue.ToString() : null;
            }

            return null;
        }
    }
}
