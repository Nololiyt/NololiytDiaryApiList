[enum_ins]: ./README.md#枚举类型
[generic_ins]: ./README.md#泛型类型

# Account相关实体

## AccountAndPassword实体
### 属性列表
|名称|类型|说明|
|:-|:-:|:-|
|Account|string|表示账户名。|
|Password|string|表示密码。|
### 服务端定义
```csharp
public class AccountAndPassword
{
    public string Account { get; set; }
    public string Password { get; set; }
}
```
### Json格式示例
```json
{
    "Account": "acc",
    "Password": "pwd"
}
```

## AccountInfo实体
### 属性列表
|名称|类型|说明|
|:-|:-:|:-|
|Account|string|表示账户名。|
|BasicAccountInfo|[BasicAccountInfo](#BasicAccountInfo实体)|表示一些基本用户信息。|
### 服务端定义
```csharp
public class AccountInfo
{
    public string Account { get; set; }
    public BasicAccountInfo BasicAccountInfo { get; set; }
}
```
### Json格式示例
```json
{
    "Account": "acc",
    "BasicAccountInfo": {
        "NickName": "nicknaaaaame"
    }
}
```

## BasicAccountInfo实体
### 属性列表
|名称|类型|说明|
|:-|:-:|:-|
|NickName|string|表示用户昵称。|
### 服务端定义
```csharp
public class BasicAccountInfo
{
    public string NickName { get; set; }
}
```
### Json格式示例
```json
{
    "NickName": "nicknameeeeeeee"
}
```

## CloseResult实体
此实体是[枚举类型][enum_ins]。
### 枚举值列表
|名称|数字|说明|
|:-|:-:|:-|
|SuccessOrRecorded|0|表示已完成或已记录。|
|WrongAccountOrPassword|1|表示用户名或密码错误。|
### 服务端定义
```csharp
public enum CloseResult
{
    SuccessOrRecorded = 0,
    WrongAccountOrPassword = 1
}
```
### Json格式示例
```json
0
```

## CreateResult实体
此实体是[枚举类型][enum_ins]。
### 枚举值列表
|名称|数字|说明|
|:-|:-:|:-|
|Success|0|表示用户创建成功。|
|IllegalAccountName|1|表示用户名不合法。|
|IllegalPassword|2|表示密码不合法。|
|OccupiedAccountName|3|表示有重名。|
### 服务端定义
```csharp
public enum CreateResult
{
    Success = 0,
    IllegalAccountName = 1,
    IllegalPassword = 2,
    OccupiedAccountName = 3
}
```
### Json格式示例
```json
3
```

## SetInfoResult实体
此实体是[枚举类型][enum_ins]。
### 枚举值列表
|名称|数字|说明|
|:-|:-:|:-|
|Success|0|表示修改成功。|
|NotSignedIn|1|表示未登录。|
### 服务端定义
```csharp
public enum SetInfoResult
{
    Success = 0,
    NotSignedIn = 1
}
```
### Json格式示例
```json
0
```

## SignInState实体
此实体是[枚举类型][enum_ins]。
### 枚举值列表
|名称|数字|说明|
|:-|:-:|:-|
|Success|0|表示用户登录成功。|
|WrongAccountOrPassword|1|表示用户名或密码错误。|
|WrongAgreementHash|2|表示用户不曾阅读过最新的用户协议。|
### 服务端定义
```csharp
public enum SignInState
{
    Success = 0,
    WrongAccountOrPassword = 1,
    WrongAgreementHash = 2
}
```
### Json格式示例
```json
1
```

## ValueWithAgreementVersion实体
此实体是[泛型类型][generic_ins]。
### 泛型参数列表
|名称|说明|
|:-|:-|
|TValue|表示绑定的值的类型。一般为[AccountAndPassword](#AccountAndPassword实体)。|
### 属性列表
|名称|类型|说明|
|:-|:-:|:-|
|CombinedValue|TValue|表示绑定的值。|
|AgreementVersion|string|表示同值绑定在一起的用户协议版本。|
### 服务端定义
```csharp
public class ValueWithAgreementVersion<TValue>
{
    public TValue CombinedValue { get; set; }
    public string AgreementVersion { get; set; }
}
```
### Json格式示例
```json
{
    "CombinedValue": {
        "Account": "acc",
        "Password": "pwd"
    },
    "AgreementVersion": "ver233.Teeeest SWBIQUB233j"
}
```
注：该示例的泛型参数 TValue 为[AccountAndPassword](#AccountAndPassword实体)。
```json
{
    "CombinedValue": {
        "Account": "acc",
        "BasicAccountInfo": {
            "NickName": "niiiiiiiickname"
        }
    },
    "AgreementVersion": "ver233.Teeeest SWBIQUB233j"
}
```
注：该示例的泛型参数 TValue 为[AccountInfo](#AccountInfo实体)。