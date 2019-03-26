using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    /// <summary>
    /// 缓存访问接口
    /// </summary>
    public interface IDBHelper_Redis
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        Task<bool> AddString(string key, string value);
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="key">键</param>
        /// <returns></returns>
        Task<string> GetString(string key);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<bool> DeleteString(string key);
    }
}
