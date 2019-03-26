using MODELS.MODEL;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDAL
{
    /// <summary>
    /// 用户类接口
    /// </summary>
    public interface IUserDAL:IDBHelper<User>,Itest
    {
    }
}
