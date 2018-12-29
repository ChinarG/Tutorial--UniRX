// ========================================================
// 描述：第二种用法：ReactiveCommand - 泛型 可用于扩展判定 Object 对象
// 作者：Chinar 
// 创建时间：2018-12-14 16:54:46
// 版 本：1.0
// ========================================================
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;


public class ChinarRxCommand2 : MonoBehaviour
{
    void Start()
    {
        //这里判定的是 Int 值，是否满足要求。然后 DoSomething...
        // 同样因为可传泛型，所以也可是对 Object 进行处理，可用性极强
        var command = new ReactiveCommand<int>(); //响应命令，可传泛型
        command.Where(_ => _ % 2 == 0).Subscribe(_ => print(_ + ">>>>>>能整除"));
        //增加 时间标记后，形参发生变化，需要指明 value 与 timestamp
        command.Where(_ => _ % 2 != 0).Timestamp().Subscribe(_ => print(_.Value + ">>>>>>不能" + _.Timestamp));
        command.Execute(8);
        command.Execute(9);
    }
}