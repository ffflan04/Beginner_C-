// 例外処理
// throwで、エラーを強制的に表示させる。
// throwで、メソッドにエラーを、返り値として、返す。

using System;

class Lesson10
{
    public static void Main()
    {
        Console.WriteLine("Hello World");

        try
        {
            int number = 2;
            int answer = 100 / number;
            Console.WriteLine(answer);
            throw new DivideByZeroException("強制エラー");  // エラーじゃないのにエラーを表示させる。
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("0では割り算できません");
            Console.Error.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("Hello C#");
        }
    }
}

