using MODELS;
using System.Threading.Tasks;

namespace IDAL
{
    /// <summary>
    /// 用户登录接口
    /// </summary>
    public interface ILoginUser:IDBHelper<LoginUser>
    {
        /// <summary>
        /// 登陆验证
        /// </summary>
        /// <param name="user">登陆用户类</param>
        /// <returns>Model</returns>
        Task<LoginUser> LoginCheck(LoginUser user);
    }
}
