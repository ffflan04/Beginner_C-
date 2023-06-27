// メソッドの定義

using System;

public class Lesson06
{
    public static void Main()
    {
        Console.WriteLine("Hello world");
        SayHello(); // コンパイル型なので後に定義されても実行可能。
    }

    public static void SayHello() // 慣習としてメソッド名の先頭は大文字にします。
    {
        Console.WriteLine("Hello paiza");  // {}で囲まれた範囲をブロックと呼びます。
    }
}


