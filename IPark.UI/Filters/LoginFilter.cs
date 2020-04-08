using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPark.UI.Filters
{
    public class LoginFilter : ActionFilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.Result =
               new RedirectToRouteResult(
                      new RouteValueDictionary
                           {
                                { "controller", "Login" },
                                { "action", "Index" }
                           });
            }
        }
    }
}
