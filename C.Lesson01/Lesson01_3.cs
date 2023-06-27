// 配列の要素をスマートに囲うために、二次元配列を作成。

using System;

public class Lesson05
{
    public static void Main()
    {
        string[] playerImages =
        {
            "空" , "ドラゴン" , "クリスタル" , "勇者" , "ヒロイン"
        };

        int[][] characters =
        {
            new int[] {1,1,1,1},
            new int[] {0,0,0,0},
            new int[] {2,3,4,2},
        };

        Console.WriteLine("<table>");
        foreach (int[] line in characters)
        {
            Console.WriteLine("<tr>");
            foreach (int imageId in line)
            {
                Console.Write("<td>" + playerImages[imageId] + "</td>");
            }
            Console.WriteLine("</tr>");
        }
        Console.WriteLine("</table>");
    }
}


