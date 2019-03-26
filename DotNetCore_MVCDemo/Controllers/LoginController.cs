using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DAL;
using IDAL;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MODELS;
using NLog;

namespace DotNetCore_MVCDemo.Controllers
{
    /// <summary>
    /// 登录控制器
    /// </summary>
    public class LoginController : BaseController
    {
        #region 字段/属性/构造函数
        /// <summary>
        /// 数据库访问类
        /// </summary>
        private ILoginUser _DBHelper;
        /// <summary>
        /// 日志
        /// </summary>
        static Logger _log = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// 缓存
        /// </summary>
        private IDBHelper_Redis _redis;
        /// <summary>
        /// 注入了redis类
        /// </summary>
        /// <param name="redis"></param>
        public LoginController(IDBHelper_Redis redis)
        {
            _redis = redis;
            _DBHelper = new LoginUserDAL();
            
        }

        #endregion
        /// <summary>
        /// 登录页面
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                //校验Cookie
                string cookiename = HttpContext.User.Claims.First().Value;
                string redistime = await _redis.GetString(cookiename);
                if (redistime.Count() != 0)
                {
                    return Redirect("/caruser/index");
                }
            }
            return View();
        }
        /// <summary>
        /// 校验登录
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Login(LoginUser user)
        {
            LoginUser result = await _DBHelper.LoginCheck(user);    //获取用户验证结果
            if (result != null)
            {
                string username = await _DBHelper.MD5encrypt16(user.LoginName);//加密username
                //Token 装入redis
                await _redis.AddString(username, DateTime.Now.ToString());          //登录加密信息，登陆时间
                //Token 装入cookie
                //var claims = new[] { new Claim("loginname", username) };                                                //证件需要的相关信息
                //var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);     //相当于证件
                //ClaimsPrincipal claimUser = new ClaimsPrincipal(claimsIdentity);                                        //相当于持有者
                //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimUser, new AuthenticationProperties()
                //{
                //    IsPersistent = true,                                //即使关闭浏览器cookie同样存在    
                //    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(60),  //cookie过期时间
                //    AllowRefresh = true                                   //cookie存在期间内再次访问站点cookie过期时间可延长
                //});

                //使用列表保存Claim
                var testclaims = new List<Claim>
                {
                    new Claim("loginname",username),//识别令牌
                    new Claim("realname",user.LoginName)//用户名
                };
                var testclaimIdentity = new ClaimsIdentity(testclaims, "passport");
                ClaimsPrincipal testuser = new ClaimsPrincipal(testclaimIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, testuser, new AuthenticationProperties()
                {
                    IsPersistent = true,                                    //即使关闭浏览器cookie同样存在    
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(60),      //cookie过期时间
                    AllowRefresh = true                                     //cookie存在期间内再次访问站点cookie过期时间可延长
                });
                //临时
                return RedirectToAction("index", "caruser");
            }
            else
            {
                ViewBag.msg = "登录失败";
                return View("index");
            }
        }
    }
}