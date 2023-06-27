// マイコード 役職の表示メソッド

using System;

public class Lesson06
{
    public static void Main()
    {
        Introduce("勇者");  // メソッドの実行
    }

    public static void Introduce(string name)  // 引数に文字列nameを指定
    {

        if (name == " " || name == "")  // メソッドの引数を運用しています
        {
            Console.WriteLine("私は村人です");
        }
        else
        {
            Console.WriteLine("私は" + name + "です");
        }


    }
}

