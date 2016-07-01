using System.Web;
using System.Web.Mvc;

namespace 离散数学动态加载数据
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}