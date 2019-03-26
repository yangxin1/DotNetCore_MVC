using System;
using System.Collections.Generic;
using System.Text;

namespace MODELS
{
    public class LoginUser
    {
        /// <summary>
        /// 主键标识
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 登陆用户名
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 用户密码（加密）
        /// </summary>
        public string LoginPassword { get; set; }
        /// <summary>
        /// 用户权限
        /// </summary>
        public int LoginLimit { get; set; }
    }
}
