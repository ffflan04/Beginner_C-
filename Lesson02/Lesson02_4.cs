// foreachの引数とスコープ範囲

using System;

public class Lesson06
{
    public static void Main()
    {
        string[] enemies = { "スライム", "モンスター", "ドラゴン" };

        foreach (var enemy in enemies)
        {
            var target = " ";
            target = enemy;
            Console.WriteLine(target);  //foreachの実行メソッドを別の変数に代入することはできる。
        }
        Console.WriteLine(enemy);  // foreachのメソッドをブロック外では、スコープ外ならしい。
    }

    public static void Attack(string target)
    {
        Console.WriteLine("勇者は" + target + "を攻撃した");
    }
}

