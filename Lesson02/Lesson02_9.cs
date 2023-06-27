// C#で配列の中から最大値を求めるメソッド

using System;

class ParamsTest
{
    static void Main()
    {
        int a = 314, b = 159, c = 265, d = 358, e = 979;
        // ↑こいつらの最大値を探したいとき、

        int[] tmp = new int[] { a, b, c, d, e };
        // ↑こんな風に一度配列に格納してから

        int max = Max(tmp);
        // ↑Max メソッドを呼び出す必要がある。

        Console.Write("{0}\n", max);
    }

    static int Max(int[] a)  // メソッドの引数に配列を指定
    {
        int max = a[0];  // 初期値を設定
        for (int i = 1; i < a.Length; ++i)  // 配列のインデックス番号をループで全て出力
        {
            if (max < a[i])  // 勝ち残りのif文だ。
                max = a[i];
        }
        return max;  // ちゃんと返して偉い
    }
}
