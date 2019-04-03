using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace DotNetCore_MVCDemo.Controllers
{
    /// <summary>
    /// 控制器帮助类
    /// </summary>
    public abstract class BaseController : Controller
    {
        /// <summary>
        /// 日志
        /// </summary>
        static readonly Logger _log = LogManager.GetCurrentClassLogger();
    }
}