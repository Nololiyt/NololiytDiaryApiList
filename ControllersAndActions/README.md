# API端口说明
+ 该文件的目录下放置了一系列API端口的说明。
+ 统一的访问链接模板如下：api/[controller]/[action]。其中文件名标识[controller]，文件内二级标题标识[action]。
+ 除非有特殊说明的，有参使用Post方法，无参使用Get方法。
+ 参数一律FromBody，建议使用json形式（其他形式不保证可行）。