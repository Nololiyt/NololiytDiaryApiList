# Account

## Current
获取当前登录的用户信息，未登录将返回null。也可以用以检测账户令牌有效性。
### 参数
#### 参数类型
byte[]
#### 参数说明
账户令牌。
#### 参数范例
```json
"AQMEFXuE5yA="
```
### 返回值
#### 返回值类型
[AccountInfo](../Entity/Account.md#AccountInfo实体)
#### 返回值说明
用户信息。
#### 返回值范例
```json
{
    "Code": 0,
    "Result": {
        "Account": "abc",
        "BasicAccountInfo": {
            "NickName": "nnnnnnnnickname"
        }
    },
    "ErrorMessage": null
}
```
当给出参数为`""`，或者令牌过期时，返回值如下所示：
```json
{
    "code": 0,
    "result": null,
    "errorMessage": null
}
```

## SignIn
登录。
### 参数
#### 参数类型
[ValueWithAgreementVersion](../Entity/Account.md#ValueWithAgreementVersion实体)\<[AccountAndPassword](../Entity/Account.md#AccountAndPassword实体)\>
#### 参数说明
若用户曾阅览过最新的协议，则AgreementVersion属性将被忽视。
#### 参数范例
```json
{
    "CombinedValue": {
        "Account": "acc",
        "Password": "pwd"
    },
    "AgreementVersion": "ver233.Teeeest SWBIQUB233j"
}
```
### 返回值
#### 返回值类型
[ValueWithAccountToken](../Entity/General.md#ValueWithAccountToken实体)\<[SignInState](../Entity/Account.md#SignInState实体)\>
#### 返回值说明
无
#### 返回值范例
```json
{
    "Code": 0,
    "Result": {
        "Value": 2,
        "AccountToken": "eunq39UNAtUW"
    },
    "ErrorMessage": null
}
```

## Create
注册。
### 参数
#### 参数类型
[AccountAndPassword](../Entity/Account.md#AccountAndPassword实体)
#### 参数说明
要设置的用户名和密码。均不得超过30字符（中文字符算1字符）。
#### 参数范例
```json
{
    "Account": "acc",
    "Password": "pwd"
}
```
### 返回值
#### 返回值类型
[CreateResult](../Entity/Account.md#CreateResult实体)
#### 返回值说明
无
#### 返回值范例
```json
{
    "Code": 0,
    "Result": 3,
    "ErrorMessage": null
}
```

## Close
移除用户。目前该功能无用，将直接返回0。
### 参数
#### 参数类型
[ValueWithAccountToken](../Entity/General.md#ValueWithAccountToken实体)\<[AccountAndPassword](../Entity/Account.md#AccountAndPassword实体)\>
#### 参数说明
要求用户处于登录状态，并确认其用户名密码进行移除，故以此为参数类型。（客户端可自行变通保存用户名密码，从而使得不需要确认，但不建议这样做）
#### 参数范例
```json
{
    "Value": {
        "Account": "acc",
        "Password": "pwd"
    },
    "AccountToken": "AQIDBAUGBwgJCgsMDQ4PEBESExQ="
}
```
### 返回值
#### 返回值类型
[CloseResult](../Entity/Account.md#CloseResult实体)
#### 返回值说明
无
#### 返回值范例
```json
{
    "Code": 0,
    "Result": 1,
    "ErrorMessage": null
}
```

## SetBasicInfo
修改用户基本信息（本来是觉得NickName算是基本信息，但其实现在想想应该是拓展信息，基本信息应该就个用户名，之后可能再做调整）。返回值表示成功与否。
### 参数
#### 参数类型
[ValueWithAccountToken](../Entity/General.md#ValueWithAccountToken实体)\<[BasicAccountInfo](../Entity/Account.md#BasicAccountInfo实体)\>
#### 参数说明
无
#### 参数范例
```json
{
    "Value": {
        "NickName": "nniicckknnaammee"
    },
    "AccountToken": "AQIDBAUGBwgJCgsMDQ4PEBESExQ="
}
```
### 返回值
#### 返回值类型
[SetInfoResult](../Entity/Account.md#SetInfoResult实体)
#### 返回值说明
无
#### 返回值范例
```json
{
    "Code": 0,
    "Result": 0,
    "ErrorMessage": null
}
```