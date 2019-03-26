using MODELS;

namespace IDAL
{
    /// <summary>
    /// 汽车用户类
    /// </summary>
    public interface ICarUser:IDBHelper<CarUser>,Itest
    {
        /// <summary>
        /// 测试方法
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        int Add(int a);
    }
}
