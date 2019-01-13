// ========================================================
// 描述：03-First 取首次/第一个数据或事件
// 作者：Chinar 
// 创建时间：2019-01-03 23:55:27
// 版 本：1.0
// ========================================================
using System.Linq;
using UniRx;
using UniRx.Triggers;
using UnityEngine;


namespace ChinarX.LinQ
{
    public class Chinar_First : MonoBehaviour
    {
        private int count = 0;


        void Start()
        {
            this.UpdateAsObservable()
                .First(_ => Input.GetMouseButtonDown(0)) //第一次点击左键时
                .Subscribe(_ => print(count++));         // 无论点击多少次，只会只在首次点击左键时输出 0
            LinQ();
        }


        private void LinQ()
        {
            int[] numbers  = {1, 2, 3, 4, 5, 6};        //数组
            var   numFirst = numbers.First(i => i > 3); //返回满足条件的第一个数据元素
            print(numFirst);                            //输出 4
        }
    }
}