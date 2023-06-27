// throwについて
// tryの中には、予測されるエラーのみを記述しろ。
// エラーの発生源はtryの中に記述しないと、プログラムが強制終了されてまう。
// エラーがないときは、tryブロックのみが実行される。
// tryブロック内でエラーが発生した場合、それ以降のコードは飛ばされ、catch , finallyと続く。

using System;

class Lesson10
{
    public static void Main()
    {
        Console.WriteLine(1);

        try
        {
            int answer = Test(0);  // Testメソッド実行時にエラーを検出したので、catchメソッドを実行。
            Console.WriteLine(7);  // エラーを検出したので、WriteLine(3)メソッドは飛ばされる。
            Console.WriteLine(answer);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(8);
            Console.WriteLine(e);
        }

    }

    static int Test(int number)
    {
        Console.WriteLine(2);
        try
        {
            Console.WriteLine(3);
            int answer = 100 / number;
            return answer;
            Console.WriteLine(4);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(5);
            throw;
        }
        Console.WriteLine(6);

    }
}

// 1, 2, 3, 5, 
