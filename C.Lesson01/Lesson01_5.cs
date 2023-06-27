// マイコード 配列の定義

using System;

public class Lesson07
{
    public static void Main()
    {
        string[] collection = new string[] { "スライム", "ゴブリン" };
        // 型名2回記述するのはくどい

        foreach (string doc in collection)
        {
            Console.WriteLine(doc);
        }
    }
}
