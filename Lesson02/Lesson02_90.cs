// 配列の中から最大値を求める(paramsを使用)
// 便利そうに見えるが、ただ配列を作る手間が１行省けるだけだ。

using System;

class ParamsTest
{
    static void Main()
    {
        int a = 314, b = 159, c = 265, d = 358, e = 979;
        // ↑こいつらの最大値を探したいとき、

        int max = Max(a, b, c, d, e);
        // ↑こうすると、自動的に配列を作って値を格納してくれる。

        Console.Write("{0}\n", max);
    }

    static int Max(params int[] a)
    {
        int max = a[0];
        for (int i = 1; i < a.Length; ++i)
        {
            if (max < a[i])
                max = a[i];
        }
        return max;
    }
}
