// クラスの継承と、インスタンス化の関係
// インスタンス化の値の経路を調べる。
// Faraway d = new Decoy("ミラージュ"); は、
// Faraway = Farawayクラスにアクセス権限ありますよ。
// d       = d という変数に、Decoyクラスと、("ミラージュ")という引数の、参照情報をコピーします。
// new Decoy("ミラージュ") = Decoyクラスを"ミラージュ"という引数でインスタンス化しまーす。

// 異なるクラスのインスタンス化は、一つの配列にまとめることはできないよ。
// インスタンス化の代入は、所詮、参照先をコピーしてるにすぎない。つまりエイリアス。
// インスタンス化から代入された変数が持っているのは、参照先のクラスと引数。
// 同じ、変数名で(new)インスタンス化することはできない。流石、初期化っていうだけあるね。
// インスタンス化の代入の型は、インスタンスのアクセス可能範囲を示している。
// 継承すると、基底クラス名の型に、派生クラスのインスタンスを代入できる。
// コンストラクタを継承することで、基底クラスの変数を取得できるので、基底クラスのメソッドを実行できる。

using System;

public class Shake
{
    public static void Main()
    {
        Faraway f = new Faraway("炭治郎");
        Faraway f01 = new Faraway("善一");
        Decoy decoy = new Decoy("Mirage");
        Faraway d = new Decoy("ミラージュ");

        Faraway[] kimetu = { f, f01, d, decoy };

        foreach (Faraway doc in kimetu)
        {
            doc.Golden();
        }
    }
}

public class Faraway
{
    public string Far { get; private set; }
    public Faraway(string far)
    {
        Far = far;
    }
    public void Golden()
    {
        Console.WriteLine("次は" + Far + "..お前の番だ。");
    }
}

public class Decoy : Faraway
{
    public string Park { get; private set; }
    public Decoy(string park) : base(park)  // 基底コンストラクタがあるとぉ。変数を継承できる。
    {
        Park = park;
    }

    public void Disguise()
    {
        Console.WriteLine("へ！ " + Park + " 騙されたな！！");
    }
}


