// ========================================================
// 描述：Where 筛选满足/限制条件
// 作者：Chinar 
// 创建时间：2019-01-03 23:55:27
// 版 本：1.0
// ========================================================
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace ChinarX.LinQ
{
    public class Chinar_Where : MonoBehaviour
    {
        /// <summary>
        /// 初始化函数
        /// </summary>
        void Start()
        {
            //一个数据列表，并添加数据
            List<Dog> dogs = new List<Dog>()
            {
                new Dog("金毛",  2000, 62),
                new Dog("二哈",  1500, 45),
                new Dog("泰迪",  1000, 15),
                new Dog("吉娃娃", 500,  10)
            };
            //1-查询 狗狗中 重量大于30
            dogs.Where(dog => dog.Weight > 30).ToList().ForEach(dog => print(dog.ToString()));
            //2-LinQ 查询 狗狗中 重量大于30
            (from dog in dogs where dog.Weight > 30 select dog).ToList().ForEach(dog => print(dog.ToString()));
        }
    }


    /// <summary>
    /// 狗狗数据类
    /// </summary>
    public class Dog
    {
        public string Name;   //名称
        public int    Price;  //价格
        public float  Weight; //重量


        /// <summary>
        /// 构造 —— 简化代码
        /// </summary>
        public Dog(string name, int price, float weight)
        {
            Name   = name;
            Price  = price;
            Weight = weight;
        }


        /// <summary>
        /// 便于打印输出看效果 —— 简化代码
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Price)}: {Price}, {nameof(Weight)}: {Weight}";
        }
    }
}