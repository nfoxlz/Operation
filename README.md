# 运动控件卡面向对象封装（Operation）
## 概述
对运动控件卡的API进行了面向对象的封装。目前仅支持**雷赛**的 **DMC3000（脉冲）** 系列运动控制卡。其它运动控制卡支持后续添加。
## 使用方法
### 配置
程序使用了雷赛的运动控制卡的函数库，所以需要提前下载。（可到[雷赛官网](https://www.leisai.com/cn/fwyzc/index_59.html)下载。）下载后，解压复制到运行目录。

注意：解压后会得到dll32、dll64，分别对应32位系统和64位系统，根据您自己的情况，仅需复制相对应的文件即可。
### 引入命名空间
```cs
using Operation.DMC;
```
### 创建对象
```cs
var card = new PulseCard3000(0);
```
在创建第1个对象时，自动初始化。参数为控制卡索引（CardInfos的第几个元素），从0开始。
### 使用
```cs
card.SetProfile(0, 500, 6000, 0.02, 0.01, 500);
card.SetSProfile(0, 0, 0);
card.PMove(0, 50000, 0);

while (card.CheckDone(0) == 0)
	……
```

### 全部使用完后关闭
```cs
DMCBase.BoardClose();
```
注意：只有全部使用完后才能关闭。

**作者邮箱：** 4043171@qq.com
