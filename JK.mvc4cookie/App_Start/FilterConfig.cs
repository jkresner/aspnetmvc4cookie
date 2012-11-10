using System.Web;
using System.Web.Mvc;

namespace JK.mvc4cookie
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}