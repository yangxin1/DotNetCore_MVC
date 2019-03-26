using DAL;
using IDAL;
using DotNetCore_MVCDemo.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLog.Web;
using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Collections.Generic;

namespace DotNetCore_MVCDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        #region 注册服务
        // 注册服务
        //public void ConfigureServices(IServiceCollection services)    //原来返回空
        public IServiceProvider ConfigureServices(IServiceCollection services)      //使用autofac 容器则设置返回值
        {
            //cookie 策略
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            //Cookie验证
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

            //MVC服务
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //路由服务
            services.AddRouting();
            //使用自带依赖注入容器
            //services.AddTransient<IUserDAL, UserDAL>();//用于Testcontroller中
            
            //使用autofac
            var Container = AutofacTest(services);          //将注入容器代码封装到了下面的一个方法中
            return new AutofacServiceProvider(Container);
        }
        #endregion 

        #region 中间件
        // 中间件
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)     //app 构建请求管道,env 运行环境,loggerFactory 日志
        {
            //异常处理中间件
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            //日志
            loggerFactory.AddNLog();
            env.ConfigureNLog("nlog.config");   //Nlog日志

            app.UseHttpsRedirection();          //HTTP重定向访问中间件
            app.UseStaticFiles();               //静态文件访问中间件
            app.UseCookiePolicy();              //cookie策略中间件
            //身份验证
            app.UseAuthentication();
            //会话
            //路由
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Sparkle",
                    template: "{controller=test}/{action=show}/{id?}");
            });            
            //调用自定义中间件(通过反射创建中间件实例)
            //app.UseMiddleware<TestMiddleware1>();
            app.UseMiddleware<TestMiddle2>();
            //路由2
            var Router = new RouteBuilder(app).MapGet("error/{code}",context=> 
            {
                var code = context.GetRouteValue("code");
                return context.Response.WriteAsync($"this is ERROR, {code}!");
            });
            var myroute = Router.Build();
            app.UseRouter(myroute);
        }
        #endregion

        #region Other
        /// <summary>
        /// 分离依赖注入
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public IContainer AutofacTest(IServiceCollection services)
        {
            var builder = new ContainerBuilder();//建立容器
            List<Assembly> programlist = new List<Assembly> { Assembly.Load("DAL"), Assembly.Load("IDAL"), Assembly.Load("MODELS"), Assembly.Load("DotNetCore_MVCDemo") };
            foreach(var q in programlist)
            {
                builder.RegisterAssemblyTypes(q).AsImplementedInterfaces();//批量注册程序集
            }
            builder.Populate(services);
            var Container = builder.Build();
            return Container;

            //Type basetype = typeof(IDBHelper<>);                                                  //获取基类型
            //builder.RegisterAssemblyTypes(typeof(UserDAL).Assembly).AsImplementedInterfaces();    //这里输入需要注入容器的类。注入容器1
            //builder.RegisterType<UserDAL>().As<IUserDAL>();                                       //注入容器2
            //builder.RegisterAssemblyTypes(typeof(CarUserDAL).Assembly).AsImplementedInterfaces(); //注入容器3
            //builder.RegisterType<DBHelper_Redis>().As<IDBHelper_Redis>();                         //注入缓存类
            //builder.Populate(services);
        }
        #endregion
    }
}
