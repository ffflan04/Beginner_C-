// プロパティを理解しよう！！
// プロパティは、private変数にアクセスする一つの手段です。
// プロパティ名 = anithing <- この記述でprivate変数にアクセスします。
// プロパティ宣言、及びsetメソッドをprivateにすることでアクセスをクラス内に限定します。
// プロパティは、private変数へのアクセスする手段の一つで、そのprivate変数のアクセス方法を限定する訳ではない。
  // つまり、クラス内なら、プロパティを使わなくてもprivate変数にアクセスできるって訳。
  // だから、private変数に他クラスからアクセスするためにプロパティを使うのなら分かるんだけどね。
  // 何が言いたいかって、プロパティをprivateにしたら、プロパティを使う意味は？直接変数に代入すればいいじゃん？


using System;

public class Lesson07
{
    public static void Main()
    {
        var apple = new Item(120, 15);  // 一つ目のインスタンス作成
        var total = apple.GetTotalPrice();
        Console.WriteLine("合計金額は" + total + "円です");
        var orange = new Item(85, 32);  // 二つ目のインスタンス作成
        Console.WriteLine("合計金額は" + orange.GetTotalPrice() + "円です");
        Console.WriteLine("商品は" + Item.Count + "種類です");

        Console.WriteLine();

        var s = new Second("propertyチェック");
        s.Remind();
    }
}

public class Item
{
    private int price;
    private int quantity;
    private static int count;  // int型のフィールドには最初に0が代入されています。

    public static int Count  // ここの名前は自由で構わない。慣例的に名前の先頭は大文字にしている。
    {
        get
        {
            return count;  // プロパティを実装することでprivateなcount変数にも値を代入できます。
        }
        private set  // privateにすることで、Itemクラス内でのみのアクセスとなる。
        {
            count = value;  // ここが引数みたいなもん
        }
    }

    public Item(int price, int quantity)  // これはコンストラクタ。呼び出される度にCount変数が+1されるよ。
    {
        this.price = price;
        this.quantity = quantity;
        Count += 1;
    }

    public int GetTotalPrice()
    {
        return price * quantity;
    }
}

public class Second
{
    private string inevitable = "色は変わりますか？";  // private変数はクラス内のアクセスが可能
    private string secret = "なんでプロパティに代入されないんですか？";


    // プロパティを実際に自分で書きたい。省略型と、普通のタイプ合わせて検証。

    public Second(string brittle)  // こちらのコンストラクタは正常に動いております。
    {
        this.secret = brittle;  // インスタンス化の際の引数を受け取ります。
    }

    public string Coincidence
    {
        get  // プロパティは、private変数にアクセスする一つの手段です。
        {    // プロパティ名 = anithing <- この記述でprivate変数にアクセスします。
            return secret;
        }
        private set  // privateでアクセスレベルがクラス内になります。
        {
            secret = value;
        }
    }

    public void Remind()
    {
        Coincidence = "privateプロパティにアクセスを試みる";  // privateプロパティにアクセスできます。
        Console.WriteLine(inevitable);
        Console.WriteLine(secret);
    }
}


