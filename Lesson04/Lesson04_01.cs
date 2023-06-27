// メソッドのオーバーライド
// え？ごめん。オーバーライドの記述する意味が分からない。
// だって、書いても書かなくてもほとんどコード量も実行結果も変わらんもん。
// メソッドをオーバーライドすることで同じメソッド名で統一感が生まれるみたいな？
// 基底クラスと同じ名前のメソッドを派生クラスに書くと、overrideを使ってメソッドを書き換えることができる。
// オーバーライドするメソッドにoverrideを付け加えます。
// 基底クラスのオーバーライドされるメソッドにvirtualを付け加えます。
// virtual修飾子をつけたメソッドは仮想メソッドと呼びます。


using System;

class Lesson08
{
    public static void Main()
    {
        var box = new Box("鋼鉄の剣");
        box.Open();

        var magicBox = new MagicBox("モノマネモンスター");
        magicBox.Look();
        magicBox.Open01();
    }
}

class Box
{
    public string Item { get; private set; }

    public Box(string item)
    {
        Item = item;
    }

    public void Open()
    {
        Console.WriteLine("宝箱を開いた。" + Item + "を手に入れた。");
    }

}

class MagicBox : Box
{
    public MagicBox(string item) : base(item)
    {
    }

    public void Look()
    {
        Console.WriteLine("宝箱は怪しく輝いている");
    }

    public void Open01()
    {
        Console.WriteLine("宝箱を開いた" + Item + "が襲ってきた");
    }
}

