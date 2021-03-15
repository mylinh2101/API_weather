using System.Web;
using System.Web.Mvc;

namespace DoanLeMyLinh_5951071049
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
