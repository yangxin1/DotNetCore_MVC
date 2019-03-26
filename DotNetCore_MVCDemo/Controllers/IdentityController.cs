using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore_MVCDemo.Tool;
using IDAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace DotNetCore_MVCDemo.Controllers
{
    /// <summary>
    /// 权限与身份验证控制器(使用过滤器进行身份验证)
    /// </summary>
    [AuthorityFilter] 
    //[Authorize]//.net core 自带的校验控件
    public class IdentityController : Controller
    {
        /// <summary>
        /// 日志
        /// </summary>
        static readonly Logger _log = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// 缓存
        /// </summary>
        private IDBHelper_Redis _redis;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="redis"></param>
        public IdentityController(IDBHelper_Redis redis)
        {
            _redis = redis;
        }
        /// <summary>
        /// 页面Action
        /// </summary>
        /// <returns></returns>
        public async Task< IActionResult> Index()
        {
            var testname = HttpContext.User.Claims.ToList();            //获取Claims
            string myname = testname.Find(x => x.Type == "realname").Value ?? "未找到数据";
            string tokenname = testname.Find(x => x.Type == "loginname").Value ?? "";
            string redisname = await _redis.GetString(tokenname);

            ViewBag.Testname = myname;    
            ViewBag.logintime = redisname;
            return View();
        }
    }
}