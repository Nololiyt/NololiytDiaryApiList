## Diaries
### Add
添加日记。参数表示日记内容。
+ 参数类型：string
+ 返回值类型：DiaryAddResult
### GetByTime
按时间倒序获取日记。未登录将返回一个长度为0的数组。
+ 参数类型：PageFactor
+ 返回值类型：DiaryInfo[]
### Search
搜索日记。未登录将返回一个长度为0的数组。目前未实现，调用将引发一个异常。
+ 参数类型：SearchFactor
+ 返回值类型：DiaryInfo[]