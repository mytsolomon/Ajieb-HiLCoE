using System.Web;
using System.Web.Mvc;

namespace Ajieb_HiLCoE_IEO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
