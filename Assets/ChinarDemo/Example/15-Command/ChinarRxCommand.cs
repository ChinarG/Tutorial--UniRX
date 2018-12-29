// ========================================================
// 描述：ReactiveCommand - 响应式命令
// 作者：Chinar 
// 创建时间：2018-12-14 16:31:27
// 版 本：1.0
// ========================================================
using UniRx;
using UniRx.Triggers;
using UnityEngine;


public class ChinarRxCommand : MonoBehaviour
{
    void Start()
    {
        //var command = new ReactiveCommand();
        //command.Subscribe(_ => print("执行!"));

        //command.Execute();//外部调用 Execute 才会被调用

        //声明2个观察量
        var mouseDownSm = this.UpdateAsObservable().Where(_ => Input.GetMouseButtonUp(0)).Select(_ => false);
        var mouseUpSm   = this.UpdateAsObservable().Where(_ => Input.GetMouseButtonDown(0)).Select(_ => true);
        var mergeSm     = Observable.Merge(mouseUpSm, mouseDownSm);  //两个观察量合并1个
        var command     = new ReactiveCommand(mergeSm, false);       //声明观察量的命令 默认为 false，保证默认不执行
        command.Subscribe(_ => print("执行命令！"));                      //观察者 订阅 print
        this.UpdateAsObservable().Subscribe(_ => command.Execute()); //当 command.Execute为True时，执行
    }
}