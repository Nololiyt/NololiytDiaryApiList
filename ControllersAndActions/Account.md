## Account
### Current
获取当前登录的用户信息，未登录将返回null（No Content）。可以用以检测是否处于登录状态。
+ 参数类型：void
+ 返回值类型：AccountInfo
### SignIn
登录。若用户曾阅览过最新的协议，则参数中AgreementVersion属性将被忽视。关于如何获取用户协议，见About(controller)下Agreement(action)。
+ 参数类型：ValueCombinedWithAgreementVersion\<AccountAndPassword\>
+ 返回值类型：SignInResult
+ 无需登录
### Create
注册。
+ 参数类型：AccountAndPassword
+ 返回值类型：CreateResult
+ 无需登录
### SignOut
登出。服务端将删除Session中储存的登录用户信息。
+ 参数类型：void
+ 返回值类型：void
+ 方法：Post
### Close
移除用户。要求用户处于登录状态。参数的目的在于确认其用户名密码进行移除（客户端可自行变通保存用户名密码，但不建议）。目前服务端不打算实现该功能，将直接返回成功。
+ 参数类型：AccountAndPassword
+ 返回值类型：CloseResult
### SetBasicInfo
修改用户基本信息（本来是觉得NickName算是基本信息，但其实现在想想应该是拓展信息，基本信息应该就个用户名，之后可能再做调整）。返回值表示成功与否。
+ 参数类型：BasicAccountInfo
+ 返回值类型：bool