// ローカル変数とスコープ(変数の有効範囲)

using System;

public class Lesson06
{
    public static void Main()
    {
        int a = 10;
        int b = 20;
        int num = Sum(a, b);  // Sumメソッドを呼び出して足し算した結果を代入
        Console.WriteLine(num);  // 代入されたnum変数を表示
        Console.WriteLine(a);  // Main変数とSum変数はスコープが分かれているので、a変数の値は異なる。
    }

    public static int Sum(int x, int y) // Sumメソッドの引数が "x" と "y" を指定
    {
        int a = 3;  //  Sumメソッドの処理内容の "a" に3を代入
        Console.WriteLine("hello " + a);

        return x + y;  // x + y の処理を返す
    }
}
