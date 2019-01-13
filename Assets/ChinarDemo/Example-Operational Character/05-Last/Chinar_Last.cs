// ========================================================
// 描述：Last —— 取最后一个元素/事件
// 作者：Chinar 
// 创建时间：2019-01-05 01:34:27
// 版 本：1.0
// ========================================================
using System.Collections.Generic;
using System.Linq;
using ChinarX.LinQ;
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


public class Chinar_Last : MonoBehaviour
{
    /// <summary>
    /// 初始化函数
    /// </summary>
    void Start()
    {
        List<Dog> dogs = new List<Dog>()
        {
            new Dog("金毛",  2000, 62),
            new Dog("二哈",  1500, 45),
            new Dog("泰迪",  1000, 15),
            new Dog("吉娃娃", 500,  10)
        };
        Dog dog = dogs.Last();                     //最后一个
        print(dog.ToString());                     //：吉娃娃
        Dog dog1 = dogs.Last(_ => _.Price > 1000); //传入条件：价格在 1000以上 的狗中的最后一个
        print(dog1.ToString());                    //：二哈


        var iObservable = Observable.Create<int>(_ =>
        {
            _.OnNext(1);
            _.OnNext(2);
            _.OnNext(3);
            _.OnNext(4);
            _.OnCompleted();
            return Disposable.Create(() => print("Disposable"));
        });
        iObservable.Last()
                   .Subscribe(_ => print(_),_=>print(_));
    }
}