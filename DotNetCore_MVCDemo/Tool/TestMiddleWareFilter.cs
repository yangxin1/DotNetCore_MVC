using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore_MVCDemo.Tool
{
    /// <summary>
    /// 中间件过滤器（用于API项目）
    /// </summary>
    public class TestMiddleWareFilter
    {
        /// <summary>
        /// 通过定义一个Configure方法允许任何站点访问
        /// </summary>
        /// <param name="applicationbuilder"></param>
        public void Configure(IApplicationBuilder applicationbuilder)
        {
            CookiePolicyOptions options = new CookiePolicyOptions();
            applicationbuilder.UseCors(config => 
            {
                config.AllowAnyOrigin();    //允许任何站点访问
            });
        }
    }
}
