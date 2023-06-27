// メソッドの定義と引数

using System;

public class Lesson06
{
    public static void Main()
    {
        string[] enemies = { "スライム", "モンスター", "ドラゴン" };

        foreach (var enemy in enemies)
        {
            Attack(enemy);  // foreachのブロック内じゃないと、"enemy"は引数にとれないらしい。
        }
        Attack("ゴブリン");  // Attackメソッドを使用
    }

    public static void Attack(string target)
    {
        Console.WriteLine("勇者は" + target + "を攻撃した");
    }
}

