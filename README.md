# Nololiyt Diaries API列表
+ 二级标题标识[controller]，三级标题标识[action]。访问链接：api/[controller]/[action]。
+ 为了阅读方便，将各个controller分为各个文件放置，位于ControllersAndActions文件夹。
+ 其中出现的自定义类型，见Entity文件夹。其中存有对应C#代码（没有逻辑性代码，一般都可读懂）。
+ 除非有特殊说明的，有参为Post，无参（参数类型void）为Get。
+ 除非有特殊说明的，参数一律FromBody，建议json形式（其他形式不保证可行，或许也可以）。
+ 登录使用Session技术。调用接口一般都需要登录，不用登录的将另作说明。