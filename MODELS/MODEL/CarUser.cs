using System;
   
namespace MODELS
{
    /// <summary>
    /// 汽车用户类
    /// </summary>
    public class CarUser
    {
        /// <summary>
        /// 所有人名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 购买时间
        /// </summary>
        public DateTime CarBuyTime { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string CarId { get; set; }
    }
}
