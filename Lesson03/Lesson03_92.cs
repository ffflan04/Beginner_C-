// マイコード プロパティの省略型を試しました。
// プロパティ省略型は、フィールド変数の定義って思って貰えばいい。
// プロパティ省略型は、代入(set)はできないけど、参照(get)することはできる、変数って理解でいい。


using System;

public class Lesson07
{
    public static void Main()
    {
        Stingy s = new Stingy();
        s.Definition();
        s.Omit = "privateやけん代入できんやろ";  // 他クラスからは、プロパティへのアクセスができません。
        Console.WriteLine(s.Omit);
    }
}

public class Stingy
{
    private string definition;

    public string Omit { get; private set; }  // もはや、フィールド変数の定義ですね。



    public void Definition()
    {
        Omit = "メソッド外でフィールド変数に代入できないか";  // クラス内なら、プロパティに代入できます。
        Console.WriteLine(Omit);
    }
}
