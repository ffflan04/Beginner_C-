// 2次元配列、要素の操作。

using System;

public class Lesson5
{
    public static void Main()
    {
        string[][] worldMap = new string[10][];    //要素を10個持った2次元配列"worldMap"を生成
        for (int i = 0; i < worldMap.Length; i++)    //"i"に0から9のループを代入。
        {
            worldMap[i] = new string[20];    //2次元配列"worldMap"のそれぞれの要素にstring20個の要素を代入。
        }

        worldMap[0][0] = "城";    //2次元配列の最下層要素に、初期値として文字列を代入してますね。
        worldMap[0][19] = "町";
        worldMap[9][19] = "町";

        for (int i = 0; i < worldMap.Length; i++)    //"i"に0から9のループを代入。
        {
            for (int j = 0; j < worldMap[i].Length; j++)    //"i"のループ変数を利用して、"j"に0から19のループを代入。
            {
                if (worldMap[i][j] == null)    //内側のif文ですね。外側のif文と&&で繋げても構いません。
                {
                    if (i % 2 == 0 || j % 3 == 0)    //代入するインデックス番号を指定していますね。
                    {
                        worldMap[i][j] = "＋";
                    }
                    else
                    {
                        worldMap[i][j] = "森";
                    }
                }
                Console.Write(worldMap[i][j]);    //これまでに代入したもの達を表示します。
            }
            Console.WriteLine();　　　　//外側のループが抜けたときに改行。
        }
    }
}
