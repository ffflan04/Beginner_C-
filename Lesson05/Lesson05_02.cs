// Dictionaryをループで出力

using System;
using System.Collections.Generic;

public class Lesson09
{
    public static void Main()
    {
        var enemyDictionary = new Dictionary<string, string>();
        enemyDictionary.Add("ザコ", "スライム");
        enemyDictionary.Add("中ボス", "ドラゴン");
        enemyDictionary.Add("ラスボス", "魔王");

        // KeyValuePairはクラスに見えて、構造体と呼ばれているデータ型なんです。
        foreach (KeyValuePair<string, string> enemy in enemyDictionary)
        {
            Console.WriteLine(enemy.Key + "の" + enemy.Value + "か現れた！");
        }

    }
}
