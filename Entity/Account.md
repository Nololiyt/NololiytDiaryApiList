# Account���ʵ��
## AccountAndPasswordʵ��
### �����б�
|����|����|˵��|
|:-|:-:|:-:|
|Account|string|��ʾ�˻�����|
|Password|string|��ʾ���롣|
### ����˴���
```csharp
public class AccountAndPassword
{
    public string Account { get; set; }
    public string Password { get; set; }
}
```
### Json��ʽʾ��
```json
{
    "Account": "acc",
    "Password": "pwd"
}
```

## AccountInfoʵ��
### �����б�
|����|����|˵��|
|:-|:-:|:-:|
|Account|string|��ʾ�˻�����|
|BasicAccountInfo|[BasicAccountInfo](#BasicAccountInfoʵ��)|��ʾһЩ�����û���Ϣ��|
### ����˴���
```csharp
public class AccountInfo
{
    public string Account { get; set; }
    public BasicAccountInfo BasicAccountInfo { get; set; }
}
```
### Json��ʽʾ��
```json
{
    "Account": "acc",
    "BasicAccountInfo": {
        "NickName": "nicknaaaaame"
    }
}
```