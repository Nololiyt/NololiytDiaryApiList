[enum_ins]: ./README.md#ö������
[generic_ins]: ./README.md#��������

# Account���ʵ��

## AccountAndPasswordʵ��
### �����б�
|����|����|˵��|
|:-|:-:|:-|
|Account|string|��ʾ�˻�����|
|Password|string|��ʾ���롣|
### ����˶���
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
|:-|:-:|:-|
|Account|string|��ʾ�˻�����|
|BasicAccountInfo|[BasicAccountInfo](#BasicAccountInfoʵ��)|��ʾһЩ�����û���Ϣ��|
### ����˶���
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

## BasicAccountInfoʵ��
### �����б�
|����|����|˵��|
|:-|:-:|:-|
|NickName|string|��ʾ�û��ǳơ�|
### ����˶���
```csharp
public class BasicAccountInfo
{
    public string NickName { get; set; }
}
```
### Json��ʽʾ��
```json
{
    "NickName": "nicknameeeeeeee"
}
```

## CloseResultʵ��
��ʵ����[ö������][enum_ins]��
### ö��ֵ�б�
|����|����|˵��|
|:-|:-:|:-|
|SuccessOrRecorded|0|��ʾ����ɻ��Ѽ�¼��|
|WrongAccountOrPassword|1|��ʾ�û������������|
### ����˶���
```csharp
public enum CloseResult
{
    SuccessOrRecorded = 0,
    WrongAccountOrPassword = 1
}
```
### Json��ʽʾ��
```json
0
```

## CreateResultʵ��
��ʵ����[ö������][enum_ins]��
### ö��ֵ�б�
|����|����|˵��|
|:-|:-:|:-|
|Success|0|��ʾ�û������ɹ���|
|IllegalAccountName|1|��ʾ�û������Ϸ���|
|IllegalPassword|2|��ʾ���벻�Ϸ���|
|OccupiedAccountName|3|��ʾ��������|
### ����˶���
```csharp
public enum CreateResult
{
    Success = 0,
    IllegalAccountName = 1,
    IllegalPassword = 2,
    OccupiedAccountName = 3
}
```
### Json��ʽʾ��
```json
3
```

## SetInfoResultʵ��
��ʵ����[ö������][enum_ins]��
### ö��ֵ�б�
|����|����|˵��|
|:-|:-:|:-|
|Success|0|��ʾ�޸ĳɹ���|
|NotSignedIn|1|��ʾδ��¼��|
### ����˶���
```csharp
public enum SetInfoResult
{
    Success = 0,
    NotSignedIn = 1
}
```
### Json��ʽʾ��
```json
0
```

## SignInStateʵ��
��ʵ����[ö������][enum_ins]��
### ö��ֵ�б�
|����|����|˵��|
|:-|:-:|:-|
|Success|0|��ʾ�û���¼�ɹ���|
|WrongAccountOrPassword|1|��ʾ�û������������|
|WrongAgreementHash|2|��ʾ�û������Ķ������µ��û�Э�顣|
### ����˶���
```csharp
public enum SignInState
{
    Success = 0,
    WrongAccountOrPassword = 1,
    WrongAgreementHash = 2
}
```
### Json��ʽʾ��
```json
1
```

## ValueWithAgreementVersionʵ��
��ʵ����[��������][generic_ins]��
### ���Ͳ����б�
|����|˵��|
|:-|:-|
|TValue|��ʾ�󶨵�ֵ�����͡�һ��Ϊ[AccountAndPassword](#AccountAndPasswordʵ��)��|
### �����б�
|����|����|˵��|
|:-|:-:|:-|
|CombinedValue|TValue|��ʾ�󶨵�ֵ��|
|AgreementVersion|string|��ʾֵͬ����һ����û�Э��汾��|
### ����˶���
```csharp
public class ValueWithAgreementVersion<TValue>
{
    public TValue CombinedValue { get; set; }
    public string AgreementVersion { get; set; }
}
```
### Json��ʽʾ��
```json
{
    "CombinedValue": {
        "Account": "acc",
        "Password": "pwd"
    },
    "AgreementVersion": "ver233.Teeeest SWBIQUB233j"
}
```
ע����ʾ���ķ��Ͳ��� TValue Ϊ[AccountAndPassword](#AccountAndPasswordʵ��)��
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
ע����ʾ���ķ��Ͳ��� TValue Ϊ[AccountInfo](#AccountInfoʵ��)��