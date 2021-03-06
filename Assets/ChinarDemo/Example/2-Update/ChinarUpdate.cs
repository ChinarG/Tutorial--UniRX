// ========================================================
// 描述：每帧刷新
// 作者：Chinar 
// 创建时间：2018-11-14 16:27:35
// 版 本：1.0
// ========================================================
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


public class ChinarUpdate : MonoBehaviour
{
    /// <summary>
    /// 初始化函数
    /// </summary>
    void Start()
    {
        //观察.Update.订阅(要做的事)
        Observable.EveryUpdate().Subscribe(_ =>
        {
            if (Input.GetMouseButtonDown(0))
            {
                print("鼠标左键");
            }
        });
        Observable.EveryUpdate().Subscribe(_ =>
        {
            if (Input.GetMouseButtonDown(1))
            {
                print("鼠标右键");
            }
        });
    }
}