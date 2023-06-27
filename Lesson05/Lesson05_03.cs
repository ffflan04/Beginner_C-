// マイコード 配列とDictionaryを組み合わせて、名簿を作った。
// 最小限の記述で効率良く書いたつもりだが。

using System;
using System.Collections.Generic;

public class Lesson09
{
    public static void Main()
    {
        var faveDictionary = new Dictionary<string, string>();
        string[] favorite = { "フラン", "霊夢", "Rachel", "クルル", "有馬" };
        string[] favebody =
        {
            "フラン・ドール＝スカーレット",
            "博麗 霊夢",
            "Rachel＝Gardner",
            "クルル・ツェぺシ",
            "有馬 騎将"
        };

        // ここでDictionaryを作成。
        for (int i = 0; i < favorite.Length; i++)
        {
            faveDictionary.Add(favorite[i], favebody[i]);
        }

        // とりあえず、出力！！
        foreach (var doc in faveDictionary)
        {
            Console.WriteLine(doc.Key + "のフルネームは、" + doc.Value);
        }

    }
}




// 授業で作成したコード
using System;
using System.Collections.Generic;

class Lesson09
{
    public static void Main()
    {
        var itemImages = new Dictionary<string, string>();
        itemImages.Add("剣", "http://paiza.jp/learning/images/sword.png");
        itemImages.Add("盾", "http://paiza.jp/learning/images/shield.png");
        itemImages.Add("回復薬", "http://paiza.jp/learning/images/potion.png");
        itemImages.Add("クリスタル", "http://paiza.jp/learning/images/crystal.png");

        string[] items = { "クリスタル", "盾", "剣", "回復薬", "回復薬", "回復薬" };

        foreach (var item in items)
        {
            Console.WriteLine(itemImages[item]);
        }
    }
}
