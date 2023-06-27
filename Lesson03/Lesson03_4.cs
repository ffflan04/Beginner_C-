// コンストラクタの初期値をループで回す

using System;

public class Lesson07
{
    public static void Main()
    {
        Enemy[] enemies =  // なんやねん。型Enemyって笑
        // アクセス修飾子をEnemy[]にする条件は？
        // A: 配列の要素がクラスであること。
        // 配列の要素がクラスであると、アクセス修飾子がクラス名になる。
        {
            new Enemy("スライム"),  // 初期化して配列に代入するイメージね。
            new Enemy("モンスター"),
            new Enemy("ドラゴン")
        };

        foreach (Enemy enemy in enemies)
        {
            enemy.Attack();
            // つまり、このコードの中身は、
            // Enemy("スライム").Attack
            // Enemy("モンスター").Attack
            // Enemy("ドラゴン").Attack
            // を順番に実行しているだけなのだ。
        }
    }
}


public class Enemy  // Enemyクラスを宣言
{
    private string monster;  // 渡される引数は単一だから、型を配列にする必要がない。

    public Enemy(string name)  // 渡される引数は単一だから、型を配列にする必要がない。
    {
        this.monster = name;  // インスタンス化した際の引数を、代入してスコープを広げる。
    }

    public void Attack()
    {
        Console.WriteLine(monster + "は勇者を攻撃した");
    }
}
