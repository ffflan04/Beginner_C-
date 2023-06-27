// マイコード クラスの継承について
// 継承すると、追加仕様が楽になるのかな。
// まぁ、継承いうても、インスタンス化の引数は別々やし、やってることは別のクラス作ってるとなんら変わらん。
// 派生コンストラクタの引数と、基底コンストラクタの引数が同じなのは、派生コンストラクタの引数を、基底コンストラクタで処理するため。
// つまり、base(rabbit)は、処理を継承し、基底クラス(rabbit)の記述と同じ役割をもつ。
// 継承することで、基底クラスのメソッドを共有できる。コンストラクタを継承することで基底クラスの変数を共有できる。

using System;

public class test
{
    public static void Main()
    {
        BeInherited i = new BeInherited("思考錯誤");
        i.Figurine();

        Inherit dupli = new Inherit("brave say ");
        dupli.Shadow();
        dupli.Figurine();
        dupli.Decoy();  // 基底クラスのメソッドを共有可能
    }
}

public class BeInherited
{
    public string Thing { get; private set; }

    public BeInherited(string inherit)
    {
        Thing = inherit;
    }

    public void Figurine()
    {
        Console.WriteLine("自分の頭で" + Thing + "することで身につける");
    }

    public void Decoy()
    {
        Console.WriteLine("デコイをだすぜー？");
    }
}

class Inherit : BeInherited  // クラスの継承にアクセス修飾子の記述はいらなかったかもしれない。
{

    public Inherit(string rabbit) : base(rabbit)  // これが派生クラスコンストラクタ
    {
    }

    public void Shadow()
    {
        Console.WriteLine(Thing + "Light shining on shadow");
    }
}


// 番外編　プライベート変数の再確認
public class Unwary
{
    public string voice = "私を使え";  // ここをprivateにすると、Unwary.voiceで呼び出せなくなるんよ。
}

public class Saddist
{
    public void Shout()
    {
        // Console.WriteLine(voice); 他クラスの変数はインスタンス化せんと使えんよ。
    }
}

// 普通だったら、他クラスのフィールド変数、publicでもアクセスできなくね？







// 継承による、コードの記述の変化、派生クラスの機能を知りたい。
