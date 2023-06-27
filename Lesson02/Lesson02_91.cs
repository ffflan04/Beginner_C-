// paramsキーワードの使い方

using System;

public class lesson06
{
    public static void Main()
    {
        Introduce("勇者");
        Introduce("魔法使い");  // 引数に指定するだけで配列を作れるんです。
        Introduce("肉壁", "囮", "捨て駒");  //  列挙しても問題ないです。
    }

    public static void Introduce(params string[] people)  // peopleという配列を作成します。
    {
        foreach (string name in people)
        {
            Console.WriteLine("私は" + name + "です");
        }
    }
}
