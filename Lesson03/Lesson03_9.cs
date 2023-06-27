// マイコード staticについて
// staticを使用することでnew = インスタンス参照？をせずともアクセスできる。
// staticを使用することでprivateでも他のクラスからアクセスできるようになる。
// staticの有無はアクセスレベルに影響を及ばさない。
// staticでフィールド変数を定義することで、インスタンス化する毎に、値を代入する必要がなくなる。
// privateフィールド変数にアクセスするには、フィールド変数、メソッドの両方にstaticを定義。
// staticメソッドには、staticフィールド変数が必要。
// 基本的にpublicならば、問題ない。
// Console.WriteLineも実は、public static修飾子が省略されているので、オブジェクトを生成しなくても使うことができる。

using System;

public class Lesson07
{
    public static void Main()  // staticと通常の変数のインスタンス化による値の変化をみていきましょう。
    {
        CanAccess can = new CanAccess();  // 1回目のインスタンス化
        CanAccess.standard = "不動";  
        can.swearing = "悪口";
        can.insult = "侮辱";
        CanAccess can01 = new CanAccess();  // 2回目のインスタンス化
        Console.WriteLine(CanAccess.standard);  // 表示される変数の中身は初期値です。
        Console.WriteLine(can01.swearing);
        Console.WriteLine(can01.insult);
    }
}

public class CanAccess
{
    public static string standard = "hudou";  // 初期値をセット
    public string swearing = "warukuti";
    public string insult = "bujoku";
}


