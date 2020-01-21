[enum_ins]: ./README.md#枚举类型
[generic_ins]: ./README.md#泛型类型

# Diaries相关实体

## CloseResult实体
此实体是[枚举类型][enum_ins]。
### 枚举值列表
|名称|数字|说明|
|:-|:-:|:-|
|Success|0|表示添加成功。|
|NotSignedIn|1|表示未登录。|
|EmptyContent|2|表示日记内容为空。|
### 服务端定义
```csharp
public enum DiaryAddResult
{
    Success = 0,
    NotSignedIn = 1,
    EmptyContent = 2
}
```
### Json格式示例
```json
2
```

## DiaryInfo实体
### 属性列表
|名称|类型|说明|
|:-|:-:|:-|
|Content|string|表示日记内容。|
|UpdateTime|DateTime|表示上传到服务端的UTC时间。|
### 服务端定义
```csharp
public class DiaryInfo
{
    public string Content { get; set; }
    /// <summary>
    /// UTC时间。
    /// </summary>
    public DateTime UpdateTime { get; set; }
}
```
### Json格式示例
```json
{
    "Content": "你好，世界！",
    "UpdateTime": "0001-01-01T00:00:00"
}
```

## PageFactor实体
### 属性列表
|名称|类型|说明|
|:-|:-:|:-|
|Count|int|表示每页的数量。为0可能导致不正常的结果。|
|PageIndex|int|表示页号。0为第一页。|
### 服务端定义
```csharp
public class PageFactor
{
    /// <summary>
    /// 表示每页的个数。
    /// </summary>
    public int Count { get; set; }
    public int PageIndex { get; set; }
}
```
### Json格式示例
```json
{
    "Count": 4,
    "PageIndex": 0
}
```

## SearchFactor实体
### 属性列表
|名称|类型|说明|
|:-|:-:|:-|
|StartTime|DateTime?|表示筛选的最早期限（UTC）。为null即为无限制。|
|EndTime|DateTime?|表示筛选的最末期限（UTC）。为null即到当前时间。|
|Keywords|string[]|表示查询关键词。为null即不设置关键词。|
|PageFactor|[PageFactor](#PageFactor实体)|表示页信息。|
### 服务端定义
```csharp
public class SearchFactor
{
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string[] Keywords { get; set; }
    public PageFactor PageFactor { get; set; }
}
```
### Json格式示例
```json
{
    "StartTime": "0001-01-01T00:00:00",
    "EndTime": null,
    "Keywords": [
        "武汉",
        "流感"
    ],
    "PageFactor": {
        "Count": 2,
        "PageIndex": 0
    }
}
```