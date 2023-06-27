// 多次元配列、foreachの使い方。

using System;

public class Lesson05
{
    public static void Main()
    {
        //多次元配列は上から考えるのではない。
        //下から考えるべき。例えば⇩
        // {n}が入ってるのは、一次元配列のint[]
        // 一次元配列int[]が入ってる配列は、二次元配列enemyImage[][]、
        //というように！！
        int[][] enemyImage = {
            new int[] {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
            new int[] {0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
            new int[] {0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0},
            new int[] {1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1},
            new int[] {1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1},
            new int[] {1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1},
            new int[] {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0}
        };

        //実行結果から分かるように、foreachは配列の中身を、
        //一次元的に排出します。
        //そんなforeachは、N次元配列、つまり、
        //配列の階層の数、foreachを重ねてあげると、
        //多次元配列の中身全てを排出できる。
        foreach (int[] line in enemyImage)
        {
            foreach (int dot in line)
            {
                if (dot == 1)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}

