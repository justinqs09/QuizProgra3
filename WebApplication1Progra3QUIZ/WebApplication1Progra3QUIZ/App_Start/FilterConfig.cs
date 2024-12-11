using System.Web;
using System.Web.Mvc;

namespace WebApplication1Progra3QUIZ
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
