// マイコード 配列の定義

using System;

public class Lesson07
{
    public static void Main()
    {
        string[] collection = new string[3];  // 要素数を守らないとエラーになるよ。
        collection[0] = "スライム";
        collection[1] = "ドラゴン";
        collection[2] = "炭治郎";


        foreach (string doc in collection)
        {
            Console.WriteLine(doc);
        }
    }
}
