using MODELS;
using IDAL;

namespace DAL
{
    /// <summary>
    /// 汽车用户访问类
    /// </summary>
    public class CarUserDAL:DBHelper<CarUser>,ICarUser
    {
        public int Add(int a)
        {
            return a + 2;
        }
    }
}
