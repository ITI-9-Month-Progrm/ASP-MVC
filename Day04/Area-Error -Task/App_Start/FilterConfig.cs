using System.Web;
using System.Web.Mvc;

namespace Area_Error__Task
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute()
            { 
                View= "myErrorPage"
            });
        }
    }
}
