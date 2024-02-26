# 运动控件卡面向对象封装（Operation）
## 概述
对运动控件卡的API进行了面向对象的封装。目前仅支持雷赛的DMC3000（脉冲）系列运动控制卡。
## 使用方法
### 首先引入命名空间
```cs
using Operation.DMC;
```
### 然后创建对象
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
