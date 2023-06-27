// 変数(フィールド)のスコープ

using System;

public class Lesson06
{
    public static void Main()
    {
        Console.WriteLine("Hello world");

        var num = 0;  // ブロックの外側で宣言したnum変数はブロックの内側でも使用できるが、
        if (num == 0)
        {
            var message = "paiza";
            Console.WriteLine(message + " " + num);
        }
        Console.WriteLine(message);  // ブロックの内側で宣言した変数は、ブロックの外側では使用できない。

        for (var i = 1; i < 5; i++)
        {
            var message = "C#";
            Console.WriteLine(message + " " + i);
        }
    }
}
