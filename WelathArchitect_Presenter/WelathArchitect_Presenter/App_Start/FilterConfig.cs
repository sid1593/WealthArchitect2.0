using System.Web;
using System.Web.Mvc;

namespace WelathArchitect_Presenter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
