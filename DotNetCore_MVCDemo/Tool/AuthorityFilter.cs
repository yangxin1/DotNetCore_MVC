using DAL;
using IDAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore_MVCDemo.Tool
{
    /// <summary>
    /// 登陆验证过滤器
    /// </summary>
    public class AuthorityFilter: ActionFilterAttribute
    {
        /// <summary>
        /// 进入action前检测
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = new RedirectResult("/login/index");
            }
        }
    }
}
