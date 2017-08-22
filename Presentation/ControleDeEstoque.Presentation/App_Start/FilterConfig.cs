using System.Web.Mvc;
using ControleDeEstoque.Presentation.Filters;

namespace ControleDeEstoque.Presentation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomErrorHandlerAttribute());
            filters.Add(new SCAAuthorizeAttribute());
        }
    }
}