// コンストラクタについて
// コンンストラクタは引数を複数とることができて、戻り値を、変数に代入することもできる。
// 

using System;

public class Lesson07
{
    public static void Main()
    {
        var apple = new Item(120, 15);
        var orange = new Item(85, 32);
        var total = apple.GetTotalPrice();
        Console.WriteLine("合計金額は" + total + "円");
        Console.WriteLine("合計金額は" + orange.GetTotalPrice() + "円");
    }
}

public class Item
{
    private int price;
    private int quantity;

    public Item(int price, int quantity)
    {
        this.price = price;
        this.quantity = quantity;
    }

    public int GetTotalPrice()
    {
        return price * quantity;
    }
}
