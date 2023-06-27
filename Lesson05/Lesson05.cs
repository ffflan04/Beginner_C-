// Dictionaryについて
// Dictionaryは配列とよく似た機能を持っていますが、
// 配列のように、数値を使ってデータにアクセスするだけでなく、
// keyと呼ばれる型でデータをまとめて管理できるので、とっても便利！
// また他のプログラミング言語では連想配列とも呼ばれてる。

// まとまったデータをテキスト(KeyとValue)で扱う
// Dictionnaryの主な用途は、DBやAPIとのやりとりなど

using System;
using System.Collections.Generic;

public class Lesson09
{
    public static void Main()
    {
        string[] enemyArray = { "スライム", "モンスター", "ドラゴン" };
        Console.WriteLine(enemyArray[0]);
        Console.WriteLine(enemyArray[1]);
        Console.WriteLine(enemyArray[2]);

        Console.WriteLine();

        var enemyDictionary = new Dictionary<string, string>();
        // Dictionaryはジェネリッククラスなのでオブジェクト作成時に型を指定します？
        enemyDictionary.Add("ザコ", "スライム");
        enemyDictionary.Add("中ボス", "ドラゴン");
        enemyDictionary.Add("ラスボス", "魔王");

        Console.WriteLine(enemyDictionary["ザコ"]);
        Console.WriteLine(enemyDictionary["中ボス"]);
        Console.WriteLine(enemyDictionary["ラスボス"]);

        Console.WriteLine();

        string level = "ザコ";
        Console.WriteLine(enemyDictionary[level]);
    }
}