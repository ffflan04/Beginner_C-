// マイコード Playerクラスに変数を埋め込みました。

using System;

public class Lesson07
{
    public static void Main()
    {
        var Player1 = new Player();
        Player1.Walk("勇者");  //メソッドの引数に値を入れて、
    }
}

public class Player
{
    public void Walk(string name)  // 別のクラスで、変数にしちゃえばいいじゃん。
    {
        Console.WriteLine(name + "は荒野を歩いていた");
    }
}

