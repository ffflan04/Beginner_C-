// メソッドの引数は丁寧に決めろ。

using System;
using System.Xml.Linq;

public class Lesson06
{
    public static void Main()
    {
        Introduce("こんにちは", "勇者"); // 引数の指定を適当にやると怒られますよー。
    }

    public static void Introduce(string greetting, string name = "村人")  // 初期値を設定する引数は末尾に記述する。
    {
        Console.WriteLine("私は" + name + "です");
    }
}
