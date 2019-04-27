using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DotNetCore_MVCDemo.Tool;
using IDAL;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MODELS;
using NLog;

namespace DotNetCore_MVCDemo.Controllers
{
    public class CarUserController : BaseController
    {
        #region 字段/属性/构造函数
        /// <summary>
        /// 数据库访问类
        /// </summary>
        private ICarUser _DBHelper;
        /// <summary>
        /// 缓存
        /// </summary>
        private IDBHelper_Redis _redis;
        /// <summary>
        /// 构造函数
        /// </summary>
        public CarUserController(ICarUser Caruser,IDBHelper_Redis redis)
        {
            _redis = redis;
            _DBHelper = Caruser; //new CarUserDAL();
        }
        #endregion

        /// <summary>
        /// 用户主页控制器
        /// </summary>
        /// <returns></returns>
        [AuthorityFilter]
        public async Task<IActionResult> Index()
        {
            //读取cookie（该步骤现已转到过滤器中执行）
            //if (HttpContext.User.Identity.IsAuthenticated)
            //{
                string cookiename = HttpContext.User.Claims.First().Value;  //从HttpContext中获取客户端cookie
                var testname = HttpContext.User.Claims.ToList();     //临时

                string myname = testname.Find(x => x.Type == "realname").Value ?? "未找到数据";
                string redistime = await _redis.GetString(cookiename);      //通过cookie从Redis中获取对应信息
                if (redistime.Count() != 0)                                 //信息对应则标识校验成功
                {
                    ViewBag.Username = cookiename;
                    ViewBag.logintime = redistime;
                    ViewBag.Testname = myname;    //临时
                }
            //}
            //else
            //{
            //    return Redirect("/login/index");                            //否则返回登陆页
            //}

            List<CarUser> result = await _DBHelper.GetList("caruser", 1, 5);
            MessageModel<CarUser> Viewmodel = new MessageModel<CarUser>
            {
                Msg = "这是测试的值"+ _DBHelper.Add(3).ToString(),
                Data = result,
                Success = true
            };
            return View(Viewmodel);
        }
        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="redisname">redis键</param>
        /// <returns>JSON</returns>
        [HttpPost]
        public async Task<JsonResult> DeleteCookie(string redisname)
        {
            bool result =  await _redis.DeleteString(redisname);//删除数据库数据
            await HttpContext.SignOutAsync();                   //删除cookie
            if (result)
            {
                return Json(new { code=1,msg="退出成功" });
            }
            else
            {
                return Json(new { code=0,msg="退出失败" });
            }
        }
    }
}