# Diaries

## Add
添加日记。
### 参数
#### 参数类型
[ValueWithAccountToken](../Entity/General.md#ValueWithAccountToken实体)\<string\>
#### 参数说明
Value 表示日记内容。
#### 参数范例
```json
{
    "Value": "我的第一个日记。",
    "AccountToken": "Fx8iFt8W"
}
```
### 返回值
#### 返回值类型
[DiaryAddResult](../Entity/Diaries.md#DiaryAddResult实体)
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

## Get
按时间倒序获取日记。
### 参数
#### 参数类型
[ValueWithAccountToken](../Entity/General.md#ValueWithAccountToken实体)\<[PageFactor](../Entity/Diaries.md#PageFactor实体)\>
#### 参数说明
无
#### 参数范例
```json
{
    "Value": {
        "Count": 3,
        "PageIndex": 1
    },
    "AccountToken": "AQIDBAUGBwgJCgsMDQ4PEBESExQ="
}
```
### 返回值
#### 返回值类型
[DiaryInfo](../Entity/Diaries.md#DiaryInfo实体)[]
#### 返回值说明
未登录将返回null。
#### 返回值范例
```json
{
    "Code": 0,
    "Result": [
        {
            "Content": "你好，世界6",
            "UpdateTime": "2020-01-21T11:55:37.3347387Z"
        },
        {
            "Content": "你好，世界5",
            "UpdateTime": "2020-01-21T07:07:37.3348566Z"
        },
        {
            "Content": "你好，世界4",
            "UpdateTime": "2020-01-11T11:55:37.334924Z"
        }
    ],
    "ErrorMessage": null
}
```

## Get
搜索日记。目前未实现，调用将引发一个异常。
### 参数
#### 参数类型
[ValueWithAccountToken](../Entity/General.md#ValueWithAccountToken实体)\<[SearchFactor](../Entity/Diaries.md#SearchFactor实体)\>
#### 参数说明
无
#### 参数范例
```json
{
    "Value": {
        "StartTime": "2020-01-16T11:58:38.1592536Z",
        "EndTime": "2020-01-21T11:58:38.1587372Z",
        "Keywords": [
            "武汉",
            "流感"
        ],
        "PageFactor": {
            "Count": 1,
            "PageIndex": 0
        }
    },
    "AccountToken": "AQIDBAUGBwgJCgsMDQ4PEBESExQ="
}
```
### 返回值
#### 返回值类型
[DiaryInfo](../Entity/Diaries.md#DiaryInfo实体)[]
#### 返回值说明
未登录将返回null。
#### 返回值范例
```json
{
    "code": 1,
    "errorMessage": "NotImplementedException : \"The method or operation is not implemented.\""
}
```