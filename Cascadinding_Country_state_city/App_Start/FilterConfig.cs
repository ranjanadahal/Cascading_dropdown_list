using System.Web;
using System.Web.Mvc;

namespace Cascadinding_Country_state_city
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
