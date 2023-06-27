// test, catch コード実行の順番。
// 実行してみて自分でチェックしてください。
// tryの中には、予測されるエラーのみを記述しろ。
// エラーの発生源はtryの中に記述しないと、プログラムが強制終了されてまう。
// エラーがないときは、tryブロックのみが実行される。
// tryブロック内でエラーが発生した場合、それ以降のコードは飛ばされ、catch , finallyと続く。

using System;

public class Lesson10
{
    public static void Main()
    {
        Console.WriteLine("メソッドの始まり");
        int num = 0;

        try
        {
            int total = Mine();
            Console.WriteLine(total);

        }
        catch (Exception e)
        {
            Console.WriteLine("一つ目のエラーを検出しました。");
            Console.Error.WriteLine(e);
            Console.WriteLine("エラーを補足しました。");
        }

        int Mine()
        {
            int number = 100 / num;
            Console.WriteLine(number);
            Console.WriteLine("エラーがなくても、tryブロックは実行されるよね？");
            return number;
        }


        try
        {
            int sum = int.Parse("");
            Console.WriteLine(sum);
            Console.WriteLine("エラーが起きるとここは実行されないのだ");
        }
        catch (Exception e)
        {
            Console.WriteLine("二つ目のエラーを検出しました");
            Console.Error.WriteLine(e);
            Console.WriteLine("二つ目のエラーを補足しました。");

        }

        Console.WriteLine("メソッドの終わり");
    }
}


