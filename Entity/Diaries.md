[enum_ins]: ./README.md#ö������
[generic_ins]: ./README.md#��������

# Diaries���ʵ��

## CloseResultʵ��
��ʵ����[ö������][enum_ins]��
### ö��ֵ�б�
|����|����|˵��|
|:-|:-:|:-|
|Success|0|��ʾ��ӳɹ���|
|NotSignedIn|1|��ʾδ��¼��|
|EmptyContent|2|��ʾ�ռ�����Ϊ�ա�|
### ����˶���
```csharp
public enum DiaryAddResult
{
    Success = 0,
    NotSignedIn = 1,
    EmptyContent = 2
}
```
### Json��ʽʾ��
```json
2
```

## DiaryInfoʵ��
### �����б�
|����|����|˵��|
|:-|:-:|:-|
|Content|string|��ʾ�ռ����ݡ�|
|UpdateTime|DateTime|��ʾ�ϴ�������˵�UTCʱ�䡣|
### ����˶���
```csharp
public class DiaryInfo
{
    public string Content { get; set; }
    /// <summary>
    /// UTCʱ�䡣
    /// </summary>
    public DateTime UpdateTime { get; set; }
}
```
### Json��ʽʾ��
```json
{
    "Content": "��ã����磡",
    "UpdateTime": "0001-01-01T00:00:00"
}
```

## PageFactorʵ��
### �����б�
|����|����|˵��|
|:-|:-:|:-|
|Count|int|��ʾÿҳ��������Ϊ0���ܵ��²������Ľ����|
|PageIndex|int|��ʾҳ�š�0Ϊ��һҳ��|
### ����˶���
```csharp
public class PageFactor
{
    /// <summary>
    /// ��ʾÿҳ�ĸ�����
    /// </summary>
    public int Count { get; set; }
    public int PageIndex { get; set; }
}
```
### Json��ʽʾ��
```json
{
    "Count": 4,
    "PageIndex": 0
}
```

## SearchFactorʵ��
### �����б�
|����|����|˵��|
|:-|:-:|:-|
|StartTime|DateTime?|��ʾɸѡ���������ޣ�UTC����Ϊnull��Ϊ�����ơ�|
|EndTime|DateTime?|��ʾɸѡ����ĩ���ޣ�UTC����Ϊnull������ǰʱ�䡣|
|Keywords|string[]|��ʾ��ѯ�ؼ��ʡ�Ϊnull�������ùؼ��ʡ�|
|PageFactor|[PageFactor](#PageFactorʵ��)|��ʾҳ��Ϣ��|
### ����˶���
```csharp
public class SearchFactor
{
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string[] Keywords { get; set; }
    public PageFactor PageFactor { get; set; }
}
```
### Json��ʽʾ��
```json
{
    "StartTime": "0001-01-01T00:00:00",
    "EndTime": null,
    "Keywords": [
        "�人",
        "����"
    ],
    "PageFactor": {
        "Count": 2,
        "PageIndex": 0
    }
}
```