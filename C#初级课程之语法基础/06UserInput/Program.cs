// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//一、用户输入

/*string name;

name = Console.ReadLine();

Console.WriteLine("我的名字是{0}",name);

Console.ReadKey();*/


//二、转义符

//常用转义符
/*
    \n 换行
    \" 英文半角双引号
    \t 表示tab键的大空格
    \b backSpace 退格键，会把前面的一个字符删掉
    \\ 表示一个 \
    @   ① 取消字符串中的转义作用     ② 将字符串按照原格式输出
 */

string path = @"D:\unity\3d";

string name = "opp";
Console.WriteLine("我的名字是\"{0}\"", name);
Console.ReadKey();