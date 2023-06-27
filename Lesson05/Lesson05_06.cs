// 実践的、例外処理コード
// Console.ReadLineのエラーをキャッチしている。

using System;

public class Lesson10
{
    public static void Main()
    {
        string[] player = { "勇者", "戦士", "魔法使い", "忍者" };
        try
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(player[num] + "はモンスターを倒した。");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("0から" + (player.Length - 1) + "を入力してください");
            Console.Error.WriteLine(e);
        }
        catch (FormatException e)
        {
            Console.WriteLine("数値を入力してください");
            Console.Error.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("そして");
            Console.WriteLine("次の冒険が始まった");
        }
    }
}
