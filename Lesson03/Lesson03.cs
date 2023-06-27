// クラスの機能説明

using System;

public class Lesson07
{
    public static void Main()
    {
        var Player1 = new Player();
        // クラス名の前に、newをつけることでオブジェクトを生成できるようになります。
        // 作ったオブジェクトは変数に割り当てておくようにしましょう。
        Player1.Walk();
        // 変数名.メソッド名でオブジェクトのメソッドを呼び出すことができます。
        // C#の変数はオブジェクトを代入することもできるんです。
    }
}

public class Player  // staticは消しております。
{
    public void Walk()
    {
        Console.WriteLine("勇者は荒野を歩いていた");
    }
}