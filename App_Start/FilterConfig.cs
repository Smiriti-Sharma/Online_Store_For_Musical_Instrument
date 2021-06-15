using System.Web;
using System.Web.Mvc;

namespace Online_Store_For_Musical_Instrument
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
