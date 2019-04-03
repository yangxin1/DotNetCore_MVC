using System.Collections.Generic;
using System.Threading.Tasks;
using IDAL;
using Microsoft.AspNetCore.Mvc;
using MODELS.MODEL;
using NLog;

namespace DotNetCore_MVCDemo.Controllers
{
    /// <summary>
    /// 用户信息控制器
    /// </summary>
    public class TestController:BaseController//Controller
    {
        #region 字段/属性/构造函数
        /// <summary>
        /// 数据库访问类
        /// </summary>
        private IUserDAL _DBHelper;
        /// <summary>
        /// 通过自带的依赖注入容器注入底层方法
        /// </summary>
        /// <param name="DBhelper">startup中的依赖注入的类</param>
        public TestController(IUserDAL DBhelper)
        {
            _DBHelper = DBhelper;
        }
        #endregion

        /// <summary>
        /// 显示主页
        /// </summary>
        /// <returns></returns>
        public IActionResult Show()
        {
            return View();
        }
        /// <summary>
        /// 分页获取数据
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> GetList(int pagesize = 1, int pagecount = 10)
        {
            List<User> resultlist = await _DBHelper.GetList("user", pagesize, pagecount);
            if (pagesize == 1)
            {
                ViewBag.lastpage = pagesize;
            }
            else
            {
                int last = pagesize - 1;
                ViewBag.lastpage = last;
            }
            int next = pagesize + 1;
            ViewBag.nextpage = next;

            //return Json( new  { resultlist=resultlist, next=next });
            return Json(resultlist);
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(User user)
        {
            if (user.Name != null)
            {
                bool result = await _DBHelper.AddModel(user, "user");
                if (result)
                {
                    return Json(new { code = 1, msg = "success" });
                }
                else
                {
                    return Json(new { code = 0, msg = "fail" });
                }
            }
            else
            {
                return Json(new { code = 0, msg = "fail" });
            }
        }
        /// <summary>
        /// 删除控制器
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            bool result = await _DBHelper.DeleteModel("user", id);
            if (result)
            {
                return Json(new { code = 1, msg = "删除成功" });
            }
            else
            {
                return Json(new { code = 0, msg = "删除失败" });
            }
        }
        /// <summary>
        /// 搜索控制器
        /// </summary>
        /// <param name="name"></param>
        /// <returns>json</returns>
        [HttpPost]
        public async Task<IActionResult> Find(string name)
        {
            User result = await _DBHelper.GetModel("user", "name", name);
            if (result != null)
            {
                return Json(new { code = 1, msg = "success", data = result });
            }
            else
            {
                return Json(new { code = 0, msg = "not found" });
            }
        }
    }
}