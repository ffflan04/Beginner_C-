// マイコード コンストラクタの初期値に配列を指定してみた
// 配列の引数をメソッドに渡して実行

using System;

public class Lesson07
{
    public static void Main()
    {
        string[] enemies = new string[] { "スライム", "ゴブリン", "ドラゴン", "炭治郎" };
        var enemy1 = new Enemy(enemies);  // 引数に配列を指定して、クラスの参照先をコピーして、
        enemy1.Attack();  // 配列の引数を渡された、EnemyクラスのAttackメソッドを実行。
    }
}

public class Enemy
{
    private string[] collections;  // name変数を配列に対応させる

    public Enemy(string[] name)  // 渡されるのは配列の引数
    {
        this.collections = name;  // 配列を格納された変数nameのスコープを広げる。
    }

    public void Attack()
    {
        foreach (string dot in collections)
        {
            Console.WriteLine(dot + "は勇者を攻撃した");
        }
    }
}


