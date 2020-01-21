# Account相关实体
## AccountAndPassword实体
### 属性列表
|名称|类型|说明|
|:-|:-:|:-:|
|Account|string|表示账户名。|
|Password|string|表示密码。|
### 服务端代码
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
|:-|:-:|:-:|
|Account|string|表示账户名。|
|BasicAccountInfo|[BasicAccountInfo](#BasicAccountInfo实体)|表示一些基本用户信息。|
### 服务端代码
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