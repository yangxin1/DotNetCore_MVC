using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore_MVCDemo.Tool
{
    /// <summary>
    /// 
    /// </summary>
    public class TestLinkMiddleware
    {
        public async Task RunLink(HttpContext context)
        {
            var url = "/Test/show";
            context.Response.ContentType = "text/plain";
            await context.Response.WriteAsync($"Go to {url} to see test view");
        }

        public void HandleMapTest(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("HandleMapTest Handler");
            });
        }
    }
}

