[enum_ins]: ./README.md#枚举类型
[generic_ins]: ./README.md#泛型类型

# About相关实体
## Agreement实体
### 属性列表
|名称|类型|说明|
|:-|:-:|:-|
|Body|string|协议内容，应该将该部分展示给用户。|
|Version|string|协议版本，在登录时需要将其作为参数提供给服务端，以便判断用户是否已阅读最新协议。|
### 服务端定义
```csharp
public class Agreement
{
    public string Body { get; set; }
    public string Version { get; set; }
}
```
### Json格式示例
```json
{
    "Body": "这是一段协议。一定要让用户康到啊！",
    "Version": "ver.233 test sdadjaHUQ"
}
```