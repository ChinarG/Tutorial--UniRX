// ========================================================
// 描述：UI事件的处理
// 作者：Chinar 
// 创建时间：2018-11-14 17:07:30
// 版 本：1.0
// ========================================================
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


/// <summary>
/// UI相关、按钮、图片、文本框
/// 脚本挂载：Canvas
/// </summary>
public class ChinarUguiOnClick : MonoBehaviour
{
    private ReactiveProperty<int> testIntProperty = new ReactiveProperty<int>(88); //指明响应属性 int，值88


    /// <summary>
    /// 初始化函数
    /// </summary>
    void Start()
    {
        //按钮的事件绑定
        //不添加 add to，绑定的监听函数不会叠加
        transform.Find("Button").GetComponent<Button>().OnClickAsObservable().Subscribe(_ => print("按钮事件被执行"));
        transform.Find("Reload Button").GetComponent<Button>().OnClickAsObservable().Subscribe(_ => { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }); //重载当前场景

        //图片的事件注册
        var image = transform.Find("Image").GetComponent<Image>();
        image.OnBeginDragAsObservable().Subscribe(_ => print("开始拖动"));
        image.OnDragAsObservable().Subscribe(_ =>
        {
            print("正在拖动");
            image.transform.position = Input.mousePosition; //移动图
        });
        image.OnEndDragAsObservable().Subscribe(_ => print("拖动完成"));

        //响应 int 直接订阅 Text
        testIntProperty.SubscribeToText(GameObject.Find("Text Subscribe").GetComponent<Text>());
    }
}