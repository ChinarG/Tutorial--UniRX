// ========================================================
// 描述：02-Select 选择并返回相应数据类型
// 作者：Chinar 
// 创建时间：2019-01-03 23:55:27
// 版 本：1.0
// ========================================================
using UniRx;
using UniRx.Triggers;
using UnityEngine;


namespace ChinarX.LinQ
{
    public class Chinar_Select : MonoBehaviour
    {
        int count = 0;


        /// <summary>
        /// 1 —— UniRx表达式
        /// 点右键
        /// </summary>
        void Start()
        {
            this.UpdateAsObservable()
                .Where(_ => Input.GetMouseButtonDown(1)) //条件
                .Select(_ => "Chinar右" + count++)         //返回 字符串 —— Chinar0 / Chinar1 / Chinar...
                .Subscribe(print);                       // 等同于<  .Subscribe(chinarEvent=>print(chinarEvent))  >
            LinQ();
        }


        /// <summary>
        /// 2 —— 查询表达式
        /// 点左键
        /// </summary>
        private void LinQ()
        {
            (from _ in this.UpdateAsObservable() where Input.GetMouseButtonDown(0) select "Chinar左" + count++).Subscribe(print);
        }
    }
}