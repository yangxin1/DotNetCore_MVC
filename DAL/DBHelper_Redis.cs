using IDAL;
using Microsoft.Extensions.Configuration;
using NLog;
using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Redis数据访问基类
    /// </summary>
    public class DBHelper_Redis:IDBHelper_Redis
    {
        /// <summary>
        /// 日志
        /// </summary>
        static readonly Logger _log = LogManager.GetCurrentClassLogger();
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _db;
        /// <summary>
        /// 构造函数
        /// </summary>
        public DBHelper_Redis()
        {
            try
            {
                var config = new ConfigurationBuilder().AddJsonFile("RedisConfig.json").Build();//读取配置文件
                string redisIP = config["Redis:configuration"];
                _redis = ConnectionMultiplexer.Connect(redisIP);
                _db = _redis.GetDatabase();
            }
            catch (Exception error)
            {
                _log.Error("未启动Redis缓存服务器，请检查配置文件(redis数据访问层)："+error.Message);
                throw new Exception("未启动Redis数据库，请检查配置文件，错误信息："+error.Message);
            }

        }

        #region 数据访问方法
        /// <summary>
        /// 添加键值对数据
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <returns>bool</returns>
        public async Task<bool> AddString(string key,string value)
        {
            return await Task.Run(() => _db.StringSet(key, value));
        }

        /// <summary>
        /// 通过key获取
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<string> GetString(string key)
        {
            return await Task.Run(() => _db.StringGet(key));
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public async Task<bool> DeleteString(string key)
        {
            return await Task.Run(() => _db.KeyDelete(key));
        }
        #endregion 
    }
}
