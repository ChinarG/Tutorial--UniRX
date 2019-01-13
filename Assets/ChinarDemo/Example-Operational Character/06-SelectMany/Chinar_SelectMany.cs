// ========================================================
// 描述：选择多个 —— 协程排序
// 作者：Chinar 
// 创建时间：2019-01-13 22:20:24
// 版 本：1.0
// ========================================================
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ChinarX.LinQ;
using UniRx;
using UnityEngine;


public class Chinar_SelectMany : MonoBehaviour
{
    private List<Dog> dogs;


    /// <summary>
    /// 初始化函数
    /// </summary>
    void Start()
    {
        dogs = new List<Dog>() //该数据用的是 1 中写好的数据
        {
            new Dog("金毛",  2000, 62),
            new Dog("二哈",  1500, 45),
            new Dog("泰迪",  1000, 15),
            new Dog("吉娃娃", 500,  10)
        };
        dogs.ToObservable().SelectMany(_ => _.Name).Subscribe(_ => print(_)); //从列表中选择返回名字，并切分为Char类型
        Chinar_UniRx();
    }


    private void LinQ()
    {
        dogs.SelectMany(_ => _.Name).ToList().ForEach(_ => print(_));
    }


    /// <summary>
    /// 在 UniRx 中的用法，可将协程以需要的顺序执行
    /// </summary>
    private void Chinar_UniRx()
    {
        var ie1 = Observable.FromCoroutine(Ie1);
        var ie2 = Observable.FromCoroutine(Ie2);
        var ie3 = Observable.FromCoroutine(Ie3);
        ie3.SelectMany(ie2.SelectMany(ie1)).Subscribe(); //协程执行顺序一一对应： 3-2-1
    }


    IEnumerator Ie1()
    {
        yield return new WaitForSeconds(0.5f);
        print(1);
    }


    IEnumerator Ie2()
    {
        yield return new WaitForSeconds(0.5f);
        print(2);
    }


    IEnumerator Ie3()
    {
        yield return new WaitForSeconds(0.5f);
        print(3);
    }
}