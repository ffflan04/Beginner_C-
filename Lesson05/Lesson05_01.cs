// Dictionaryの機能
// .Countメソッド、.Removeメソッド、Keyに対するValueの代入。

using System;
using System.Collections.Generic;

public class Lesson09
{
    public static void Main()
    {
        var enemyDictionary = new Dictionary<string, string>();
        // Dictionaryはジェネリッククラスなのでオブジェクト作成時に型を指定します？
        enemyDictionary.Add("ザコ", "スライム");
        enemyDictionary.Add("中ボス", "ドラゴン");
        enemyDictionary.Add("ラスボス", "魔王");

        Console.WriteLine(enemyDictionary["ザコ"]);
        Console.WriteLine(enemyDictionary["中ボス"]);
        Console.WriteLine(enemyDictionary["ラスボス"]);

        Console.WriteLine(enemyDictionary.Count);  // KeuとValueのペア数を取得

        enemyDictionary["中ボス"] = "レッドドラゴン";  // 対象のKeyに対するValueの代入
        Console.WriteLine(enemyDictionary["中ボス"]);

        enemyDictionary.Remove("ラスボス");  // 指定したkeyとvalueが削除されます。
        Console.WriteLine(enemyDictionary.Count);
    }
}
