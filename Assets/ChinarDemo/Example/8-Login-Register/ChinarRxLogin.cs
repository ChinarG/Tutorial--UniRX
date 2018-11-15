// ========================================================
// 描述：登录注册
// 作者：Chinar 
// 创建时间：2018-11-15 17:00:18
// 版 本：1.0
// ========================================================
using UniRx;
using UnityEngine;
using UnityEngine.UI;


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


public class ChinarRxLogin : MonoBehaviour
{
    private Button     loginButton;
    private Button registerButton;
    private InputField userInputField;
    private InputField passInputField;

    
    void Awake()
    {
        loginButton    = transform.Find("Login Button").GetComponent<Button>();
        registerButton = transform.Find("Register Button").GetComponent<Button>();
        userInputField = transform.Find("User").GetComponent<InputField>();
        passInputField = transform.Find("Pass").GetComponent<InputField>();
    }


    /// <summary>
    /// 初始化函数
    /// </summary>
    void Start()
    {
        //结束编辑时，提交
        userInputField.OnEndEditAsObservable().Subscribe(_ => passInputField.Select()); //按下回车，直接切换到密码输入框
        passInputField.OnEndEditAsObservable().Subscribe(_ => loginButton.onClick.Invoke());//回车后，直接登录
        loginButton.OnClickAsObservable().Subscribe(_ => print("登录"));
        registerButton.OnClickAsObservable().Subscribe(_ => print(1));
    }
}