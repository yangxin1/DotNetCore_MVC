using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Threading.Tasks;

namespace DotNetCore_MVCDemo.Middleware
{
    #region 中间件1
    /// <summary>
    /// 中间件Demo1
    /// </summary>
    public class TestMiddleware1
    {
        private readonly RequestDelegate _next;
        static readonly Logger _log = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="next"></param>{
        /// 
        public TestMiddleware1(RequestDelegate next)
        {
            _next = next ?? throw new ArgumentException(nameof(next));
        }
        /// <summary>
        /// 中间件方法
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
            //业务逻辑
            _log.Info("中间件执行逻辑A——开始");
            _log.Info("请求方式："+context.Request.Method);
            if (context.Request.Method =="GET")
            {
                _log.Info("中间件逻辑A——完成请求方式判断");
                await _next(context);//等待下一个中间件执行
                _log.Info("中间件逻辑A——完成中间件逻辑");
            }
            else
            {
                _log.Info("中间件逻辑A——未完成判断");
                return;//return之后不会再执行后续的中间件（包括MVC路由等）
            }
        }
    }
    #endregion

    #region 中间件2
    /// <summary>
    /// 中间件Demo2
    /// </summary>
    public class TestMiddle2
    {
        private readonly RequestDelegate _next;
        static readonly Logger _log = LogManager.GetCurrentClassLogger();
        public TestMiddle2(RequestDelegate next)
        {
            _next = next??throw new ArgumentException(nameof(next));
        }
        public async Task Invoke(HttpContext context)
        {
            _log.Info("中间件执行逻辑B——开始");
            
            _log.Info("中间件B逻辑：获取请求路径："+context.Request.Path);
            await _next(context);
            _log.Info("中间件执行逻辑B——结束");
        }
    }
    #endregion
}
