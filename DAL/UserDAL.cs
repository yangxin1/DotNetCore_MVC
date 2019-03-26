using IDAL;
using MODELS.MODEL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 用户DAL
    /// </summary>
    public class UserDAL : DBHelper<User>,IUserDAL
    {
    }
}
