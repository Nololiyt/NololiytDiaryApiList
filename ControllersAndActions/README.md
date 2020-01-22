# API端口说明
+ 该文件的目录下放置了一系列API端口的说明。
+ 统一的路由如下：api/[controller]/[action]。其中文件名标识[controller]，文件内二级标题标识[action]。不区分大小写，比如`https://api.diary.nololiyt.top/api/about/agreement`。
+ 除非有特殊说明的，有参使用`POST`方法，无参使用`GET`方法。
+ 参数一律放在请求体中，建议使用json形式（其他形式不保证可行）。