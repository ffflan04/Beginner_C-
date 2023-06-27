// マイコード プロパティについて
// プロパティ本体にも、プロパティの返り値にも同じ値が入っている。
// プロパティに対する代入は、mainメソッド内、当クラスからでも、"プロパティ名 = anithing"で基本いける。

using System;

public class First
{
    public static void Main()
    {
        Property p = new Property();

        p.Drawout();

    }
}

public class Property
{
    private int money;  // プライベートフィールド変数の宣言

    private int Count  // これがプロパティ
    {
        get
        {
            return money;
        }
        set
        {
            money = value;
        }
    }

    public void Drawout()
    {
        Count = 120;
        Console.WriteLine(money);  // 処理結果 120
        Console.WriteLine(Count);  // 処理結果 120
    }
}

