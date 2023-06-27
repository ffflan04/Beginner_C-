// メソッドのオーバーロード
// メソッドのオーバーロードを使うと同じメソッド名で
// 引数の数やデータ型が異なるメソッドを定義することができる
// 実行結果で分かると思うが、同じメソッド名だが、引数とデータ型の違いで、別々にメソッドを定義できる。

using System;

public class Lesson08
{
    public static void Main()
    {
        Attack();
        Attack("スライム");
        Attack(10);
        Attack("ドラゴン", 3);
    }

    static void Attack()
    {
        Console.WriteLine("勇者は、敵を攻撃した。");
    }

    static void Attack(string target)
    {
        Console.WriteLine("勇者は" + target + "を攻撃した。");
    }

    static void Attack(int number)
    {
        Console.WriteLine("勇者は、" + number + "匹の敵を攻撃した。");
    }

    static void Attack(string target, int number)
    {
        Console.WriteLine("勇者は" + number + "匹の" + target + "を攻撃した。");
    }
}
