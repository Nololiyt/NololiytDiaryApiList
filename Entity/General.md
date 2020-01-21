[enum_ins]: ./README.md#枚举类型
[generic_ins]: ./README.md#泛型类型

# 全局实体
## Reply实体
各接口的返回值都会由Reply实体进行包装后返回。  
由于泛型类型参数不允许为void，因此Reply实体有两种类型——一种为[泛型类型][generic_ins]，用于有返回值的接口；另一种不是，用户无返回值的接口。  
两者其实有办法统一，具体详见下文服务端定义。但为了描述方便，服务端使用的是非统一的版本。其中对于无返回值的接口，均使用非泛型版本；对于有返回值的接口，出现错误仍使用非泛型版本，正常返回则将使用泛型版本。
### 服务端定义
```csharp
public class Reply
{
    public ReplyCode Code { get; set; }
    public string ErrorMessage { get; set; }
}
public class Reply<TResult>
{
    public ReplyCode Code { get; set; }
    public TResult Result { get; set; }
    public string ErrorMessage { get; set; }
}
/*
 * 以上两种格式可以统一为以下格式：
 *  public class Reply
 *  {
 *      public ReplyCode Code { get; set; }
 *      public dynamic Result { get; set; }
 *      public string ErrorMessage { get; set; }
 *  }
 */
```
### 非泛型版本的Reply实体详细说明
#### 属性列表
|名称|类型|说明|
|:-|:-:|:-|
|Code|[ReplyCode](#ReplyCode实体)|表示执行状态。|
|ErrorMessage|string|表示错误，若Code为0（Success）则值为null。|
### 泛型版本的Reply实体详细说明
#### 泛型参数列表
|名称|说明|
|:-|:-|
|TResult|表示接口返回值的类型。|
#### 属性列表
|名称|类型|说明|
|:-|:-:|:-|
|Code|[ReplyCode](#ReplyCode实体)|表示执行状态。|
|Result|TResult|表示接口返回的值。若Code不为0（Success）则值为null。|
|ErrorMessage|string|表示错误。若Code为0（Success）则值为null。|
### Json格式示例
```json
{
    "code": 0,
    "result": {
        "body": "Hellllllo!",
        "version": "Test!"
    },
    "errorMessage": null
}
```
```json
{
    "Code": 1,
    "ErrorMessage": "StrangeException : \"You are so strange that you want an exception!\""
}
```

## ReplyCode实体
此实体是[枚举类型][enum_ins]。此实体只配合[Reply实体](#Reply实体)使用。
### 枚举值列表
|名称|数字|说明|
|:-|:-:|:-|
|SuccessOrRecorded|0|表示已完成或已记录。|
|WrongAccountOrPassword|1|表示用户名或密码错误。|

其枚举值只列出了0和1两种，在某些情况下可能为其他值，但只有0表示正常。
### 服务端定义
```csharp
public enum ReplyCode
{
    NoErrors = 0,
    Error = 1,
    // 剩余数字保留。
}
```
### Json格式示例
```json
0
```

## ValueWithAccountToken实体
此实体是[泛型类型][generic_ins]。用以为需要登录的接口提供账户令牌和参数。
### 泛型参数列表
|名称|说明|
|:-|:-|
|TValue|表示参数值的类型。|
### 属性列表
|名称|类型|说明|
|:-|:-:|:-|
|Value|TValue|表示参数值。|
|AccountToken|byte[]|表示账户令牌。|
### 服务端定义
```csharp
public class ValueWithAccountToken<TValue>
{
    public TValue Value { get; set; }
    public byte[] AccountToken { get; set; }
}
```
### Json格式示例
```json
{
    "Value": "我的第一个日记。",
    "AccountToken": "Fx8iFt8W"
}
```
注：该示例的泛型参数 TValue 为 string 。
```json
{
    "Value": {
        "NickName": "nicccccccckname"
    },
    "AccountToken": "Fx8iFt8W"
}
```
注：该示例的泛型参数 TValue 为[BasicAccountInfo](./Account.md#BasicAccountInfo实体)。