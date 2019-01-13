// ========================================================
// 描述：
// 作者：Chinar 
// 创建时间：2019-01-08 22:43:26
// 版 本：1.0
// ========================================================
using System.Collections.Generic;
using UniRx;
using UnityEngine;


#region Chinar Icon

/*
##########################################################################################################################$
##########################################################################################################################$
##########################################################################################################################$
##########################################################################################################################$
##########################################################################################################################$
##########################################################################################################################$
##########################################################@$@#############################################################$
#######################################################&:     :&##########################################################$
#####################################################|           !########################################################$
##################################################@;               :@#####################################################$
################################################@;                   ;@###################################################$
###############################################|                       |##################################################$
#############################################@:                         '&################################################$
############################################$`                           .$###############################################$
###########################################%.                             .%##############################################$
##########################################$`                               `$#############################################$
#########################################&'                                 '&############################################$
##########################$.    :&#######!                                   !#######&:    .%#############################$
##########################&'       |####&'                                   '&####|       '&#############################$
###########################%.       :@##%.                                   .%##@:       .%##############################$
############################&'       ;##|                                     |##;       '&###############################$
##############################@:     `$#|                                     |#&`     :@#################################$
###################################@&&##%.                                    |##&&@######################################$
################$:.                 '|@#$`                                   `$#@|'                 .;$###################$
###############!                                                                                       !##################$
###############&'                                                                                     '&##################$
################%.                                                                                    %###################$
#################!                                                                                   !####################$
##################!                                                                                 !#####################$
###################|                                                                               |######################$
####################&'                                                                           '&#######################$
######################|                                                                         |#########################$
########################!                                                                     ;###########################$
##########################%.                                                               .|#############################$
############################@;                                                           ;@###############################$
####################@;       `$#$`                                                   `%#$`       ;@#######################$
####################%.       !#&'                         `;`                         `$#|       .%#######################$
#############################%.                          '&#&'                          .%################################$
###########################&'                           !#####!                           '&##############################$
##########################%.                          :@#$%%%$#@;                          .%#############################$
#########################|                          !###&'   '&###!                          |############################$
##########################@;                    .|######&'   '&######|.                    ;@#############################$
###############################$;`         '!&##########&'   '&##########&|'         `;&##################################$
########################################################&'   '&###########################################################$
########################################################&'   '&###########################################################$
########################################################&'   '&###########################################################$
########################################################&'   '&###########################################################$
########################################################&'   '&###########################################################$
########################################################&'   '&###########################################################$
########################################################&'   '&###########################################################$
#########################################################&$$$&############################################################$
##########################################################@@@#############################################################$
####################&$$$$$&######&;`%###################&'   '&###########################################################$
###############|.          %#####$` !###################&'   '&###########################################################$
#############;  .|###############$` !#####################################################################################$
###########&' `$#################$` !#####################################################################################$
###########; '&##################$`            :@########@: ;#########$`      .|########|         ;@#####@:    `$#########$
##########$` !###################$` ;########@: .%#######@: ;#######@:  !####|. '&##############@: `$###$` :@#############$
##########$` |###################$` ;#########%. |#######@: ;#######! `$######$` !#######|.         %###% .%##############$
###########; '&##################$` ;#########%. |#######@: ;#######; '&######&' !#####%. .%#####%  %###% .%##############$
###########@: `$#################$` ;#########%. |#######@: ;#######; '&######&' !#####; :@######%  %###% .%##############$
#############!   !###############$` ;#########%. |#######@: ;#######; '&######&' !#####| .%######%  %###% .%##############$
###############%`          %#####$` ;#########%. |#######@: ;#######; '&######&' !######%.          %###% .%##############$
##########################################################################################################################$
##########################################################################################################################$
##########################################################################################################################$
##########################################################################################################################$
##########################################################################################################################$
##########################################################################################################################$
*/

#endregion


public class ChinarTest : MonoBehaviour
{
    List<GameObject>                       gameObjects = new List<GameObject>();
    private ReactiveCollection<GameObject> gameObjectsReactiveCollection /*=new ReactiveCollection<GameObject>()*/;


    /// <summary>
    /// 初始化函数
    /// </summary>
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            gameObjects.Add(new GameObject(i.ToString()));
        }

        //var s=gameObjects.ObserveEveryValueChanged(_ =>
        //{
        //    print(_.Count+"--------");
        //    return _;
        //});
        //s.Subscribe(_ =>
        //{
        //    print(_.Count);
        //});
        gameObjects.ObserveEveryValueChanged(_ => _.Count)
                   .Subscribe(_=>print(_.ToString()));
    }


    /// <summary>
    /// 
    /// </summary>
    private void MethodName()
    {
        for (int i = 0; i < 10; i++)
        {
            gameObjects.Add(new GameObject(i.ToString()));
        }

        gameObjectsReactiveCollection = gameObjects.ToReactiveCollection();
        print(gameObjects.Count);
        print(gameObjectsReactiveCollection.Count);
        gameObjectsReactiveCollection.ObserveAdd().Subscribe(_ => print("添加："          + _));
        gameObjectsReactiveCollection.ObserveMove().Subscribe(_ => print("移除："         + _));
        gameObjectsReactiveCollection.ObserveCountChanged().Subscribe(_ => print("数量：" + _));
        gameObjectsReactiveCollection.ObserveReplace().Subscribe(_ => print("替换："      + _));
        gameObjectsReactiveCollection.ObserveReset().Subscribe(_ => print("重置："        + _));
        print("=============");
        gameObjects.Clear();
        print(gameObjects.Count);
        print(gameObjectsReactiveCollection.Count);
    }


    /// <summary>
    /// 每帧刷新
    /// </summary>
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObjects.Add(new GameObject());
        }

        if (Input.GetMouseButtonDown(1))
        {
            gameObjects.RemoveAt(0);
        }
    }
}