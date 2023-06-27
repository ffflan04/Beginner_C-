// 例外のクラス構成について学習します。
// Exceptionクラスは全ての例外の基底クラスになっています。
// はい。Linuxのディレクトリ構造に似ていますよね。

using System;

class Lesson10
{
    public static void Main()
    {
        try
        {
            //throw new Exception();
            //throw new FormatException();
            //throw new IndexOutOfRangeException();
            //throw new DivideByZeroException();
            throw new ArgumentNullException();
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(1);
            Console.WriteLine(e);
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine(2);
            Console.WriteLine(e);
        }
        catch (SystemException e)
        {
            Console.WriteLine(3);
            Console.WriteLine(e);
        }
        catch (Exception e)
        {
            Console.WriteLine(4);
            Console.WriteLine(e);
        }
    }
}
