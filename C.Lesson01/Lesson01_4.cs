// Console.ReadLine()をforeachで出力。

using System;

public class Lesson05
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());    //標準入力をParseメソッドで数値に変換して、代入してます。

        string[][] table = new string[number][];    //number変数個の要素を持つtableという文字列型の2次元配列を作成。
        for (int i = 0; i < number; i++)    //number変数の数"i"でループを回す。多分、table.lengthでも代用可能。
        {
            table[i] = Console.ReadLine().Split(' ');    //インデックス番号"i"番目のtable配列に、標準入力を代入。
        }
        foreach (string[] line in table)    //table二次元配列を最下層まで掘り出します。
        {
            foreach (string dot in line)
            {
                if (dot == "1")
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}


