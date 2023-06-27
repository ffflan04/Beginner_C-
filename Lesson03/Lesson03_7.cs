// void型について
// クラスのインスタンス化について
// void型は戻り値がないから処理結果を変数に代入できなかった。
// インスタンス化したクラスを代入する先の変数の型は、まさかのクラス名..

using System;

public class Lesson07
{
    public static void Main()
    {
        Player player = new Player("勇者");
        player.Walk();  // void型は戻り値がないから、braveに処理結果を代入することはできないのか。
    }
}

public class Player
{
    private string name;

    public Player(string name)
    {
        this.name = name;
    }

    public void Walk()
    {
        Console.WriteLine(name + "は荒野を歩いていた");
    }
}
