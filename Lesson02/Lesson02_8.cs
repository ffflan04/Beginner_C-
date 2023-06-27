// 引数にラベルをつける、名前付き引数。keyと値みたいな？

using System;

public class Lesson06
{
    public static void Main()
    {
        SayHello();
        SayHello("こんにちは" + "皆");
        SayHello("Good morning");
        SayHello(greetting: "こんにちは", target: "皆さん");  // ハッシュみたいに引数を指定できる。
    }

    public static void SayHello(string greetting = "Hello", string target = "World")
    {
        Console.WriteLine(greetting + " " + target);
    }
}
