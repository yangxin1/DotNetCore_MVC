using IDAL;
using MODELS;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 用户登录DAL
    /// </summary>
    public class LoginUserDAL:DBHelper<LoginUser>,ILoginUser
    {
        /// <summary>
        /// 登陆验证类
        /// </summary>
        /// <param name="user">登陆类</param>
        /// <returns>model</returns>
        public async Task<LoginUser> LoginCheck(LoginUser user)
        {
            user.LoginPassword = await MD5encrypt16(user.LoginPassword);//加密password
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from loginuser where loginname='" + user.LoginName + "' and loginpassword='" + user.LoginPassword + "'");
            return await ExecuteToModel(sql.ToString());//比对
        }
    }
}
