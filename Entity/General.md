[enum_ins]: ./README.md#ö������
[generic_ins]: ./README.md#��������

# ȫ��ʵ��
## Replyʵ��
���ӿڵķ���ֵ������Replyʵ����а�װ�󷵻ء�  
���ڷ������Ͳ���������Ϊvoid�����Replyʵ�����������͡���һ��Ϊ[��������][generic_ins]�������з���ֵ�Ľӿڣ���һ�ֲ��ǣ��û��޷���ֵ�Ľӿڡ�  
������ʵ�а취ͳһ������������ķ���˶��塣��Ϊ���������㣬�����ʹ�õ��Ƿ�ͳһ�İ汾�����ж����޷���ֵ�Ľӿڣ���ʹ�÷Ƿ��Ͱ汾�������з���ֵ�Ľӿڣ����ִ�����ʹ�÷Ƿ��Ͱ汾������������ʹ�÷��Ͱ汾��
### ����˶���
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
 * �������ָ�ʽ����ͳһΪ���¸�ʽ��
 *  public class Reply
 *  {
 *      public ReplyCode Code { get; set; }
 *      public dynamic Result { get; set; }
 *      public string ErrorMessage { get; set; }
 *  }
 */
```
### �Ƿ��Ͱ汾��Replyʵ����ϸ˵��
#### �����б�
|����|����|˵��|
|:-|:-:|:-|
|Code|[ReplyCode](#ReplyCodeʵ��)|��ʾִ��״̬��|
|ErrorMessage|string|��ʾ������CodeΪ0��Success����ֵΪnull��|
### ���Ͱ汾��Replyʵ����ϸ˵��
#### ���Ͳ����б�
|����|˵��|
|:-|:-|
|TResult|��ʾ�ӿڷ���ֵ�����͡�|
#### �����б�
|����|����|˵��|
|:-|:-:|:-|
|Code|[ReplyCode](#ReplyCodeʵ��)|��ʾִ��״̬��|
|Result|TResult|��ʾ�ӿڷ��ص�ֵ����Code��Ϊ0��Success����ֵΪnull��|
|ErrorMessage|string|��ʾ������CodeΪ0��Success����ֵΪnull��|
### Json��ʽʾ��
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

## ReplyCodeʵ��
��ʵ����[ö������][enum_ins]����ʵ��ֻ���[Replyʵ��](#Replyʵ��)ʹ�á�
### ö��ֵ�б�
|����|����|˵��|
|:-|:-:|:-|
|SuccessOrRecorded|0|��ʾ����ɻ��Ѽ�¼��|
|WrongAccountOrPassword|1|��ʾ�û������������|

��ö��ֵֻ�г���0��1���֣���ĳЩ����¿���Ϊ����ֵ����ֻ��0��ʾ������
### ����˶���
```csharp
public enum ReplyCode
{
    NoErrors = 0,
    Error = 1,
    // ʣ�����ֱ�����
}
```
### Json��ʽʾ��
```json
0
```

## ValueWithAccountTokenʵ��
��ʵ����[��������][generic_ins]������Ϊ��Ҫ��¼�Ľӿ��ṩ�˻����ƺͲ�����
### ���Ͳ����б�
|����|˵��|
|:-|:-|
|TValue|��ʾ����ֵ�����͡�|
### �����б�
|����|����|˵��|
|:-|:-:|:-|
|Value|TValue|��ʾ����ֵ��|
|AccountToken|byte[]|��ʾ�˻����ơ�|
### ����˶���
```csharp
public class ValueWithAccountToken<TValue>
{
    public TValue Value { get; set; }
    public byte[] AccountToken { get; set; }
}
```
### Json��ʽʾ��
```json
{
    "Value": "�ҵĵ�һ���ռǡ�",
    "AccountToken": "Fx8iFt8W"
}
```
ע����ʾ���ķ��Ͳ��� TValue Ϊ string ��
```json
{
    "Value": {
        "NickName": "nicccccccckname"
    },
    "AccountToken": "Fx8iFt8W"
}
```
ע����ʾ���ķ��Ͳ��� TValue Ϊ[BasicAccountInfo](./Account.md#BasicAccountInfoʵ��)��