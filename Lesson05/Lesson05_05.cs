// 例外処理の概要
// 例外処理を書かんと、エラーでプログラムが強制終了になってしまうねん。
// 実行時エラータブは標準エラー出力の内容を出力します。
// プログラムの実行環境では、多くの場合、この標準入力に加えて、標準出力と、標準エラー出力という機能を持っています。
// C#のプログラムでは、Console.WriteLineで標準出力に結果を出力して、
// Console.Error.WriteLineで標準エラー出力に結果を出力します。
// 例外ハンドラ→catchは複数定義することができる。

using System;

public class Lesson10
{
    public static void Main()
    {
        Console.WriteLine("Hello World");

        try
        {
            int number = 0;
            int answer = 100 / number;
            Console.WriteLine(answer);
        }
        catch (Exception ea)
        {
            Console.Error.WriteLine("0では割り算できません。");
            Console.Error.WriteLine(ea.Message);  // .Messageはエラーを簡潔に表示するプロパティ
            Console.WriteLine(ea);  // Exceptionオブジェクトの変数は、エラーの全文が格納されてる。
        }
        finally
        {
            Console.WriteLine("Hello C#");
        }
        Console.WriteLine();



        try
        {
            // 数値を文字列から変換するときに例外を発生させてみます。
            int number = int.Parse("5");  // "5"という文字列をParseメソッドで数値に変換してます。
            int answer = 100 / number;
            Console.WriteLine(answer);
        }
        catch (Exception e)  // このExceptionは色々な例外を取得できます。
        {
            Console.Error.WriteLine("0では割り算できません");
            Console.Error.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("Hello C#");
        }
        Console.WriteLine();



        try
        {
            int number = 0;
            int divid = 100 / number;
            Console.WriteLine(divid);
        }
        catch (DivideByZeroException i)  // 0で割り算したときのエラーを補足するException
        {
            Console.WriteLine(i);
        }
        finally
        {
            Console.WriteLine("Hello C#");
        }
        Console.WriteLine();



        try
        {
            int number = int.Parse("a");
            int answer = 100 / number;
            Console.WriteLine(answer);
        }
        catch (FormatException a)  // 無効な引数のエラーを補足するException
        {
            Console.Error.WriteLine("引数が無効な形式です。");
            Console.Error.WriteLine(a);
        }
        finally
        {
            Console.WriteLine("Hello C#");
        }
        Console.WriteLine();



        // 例外ハンドラは複数定義することができる。
        try
        {
            int number = int.Parse(Console.ReadLine());
            int answer = 100 / number;
            Console.WriteLine(answer);
        }
        catch (FormatException e)
        {
            Console.Error.WriteLine("引数が無効な形式です");
            Console.Error.WriteLine(e);
        }
        catch (DivideByZeroException e)  // 複数の例外ハンドラ
        {
            Console.Error.WriteLine("0では割り算できません");
            Console.Error.WriteLine(e);
        }
        catch (Exception e)
        // Exceptionクラスは全ての例外の基底クラスになっているので、
        // どの例外もExceptionオブジェクトとして補足できるんですよ。
        // 子要素になるハンドラを上から記述しないとエラーが起こる。
        {
            Console.Error.WriteLine("例外を補足しました。");
            Console.Error.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("Hello C#");
        }
    }
}
