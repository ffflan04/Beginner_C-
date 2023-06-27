// 文字列や配列もオブジェクトになっている。
// はぁ..そうですか。

using System;

public class Lesson07
{
    public static void Main()
    {
        var text = "Hello World";  // 文字列オブジェクトを作ってみよう。
        Console.WriteLine(text);  // 文字列はオブジェクトなのでメソッドやプロパティで呼び出すことができます。
        Console.WriteLine(text.Length);  // Lengthプロパティで、要素の長さを調べてみましょう。
        Console.WriteLine(text.ToUpper());  // このように、文字列はStringクラスのオブジェクトなんですよー！

        int[] numbers = { 1, 2, 3, 4 };  // この配列もオブジェクトなんで、メソッドやプロパティがあります。
        foreach (int number in numbers)
        {
            Console.WriteLine(number + " ");
        }
        Console.WriteLine();

        numbers.SetValue(100, 2);  // SetValueメソッドでインデックス番号２の要素を"100"に置き換えました。
        foreach (int number in numbers)
        {
            Console.WriteLine(number + " ");
        }
        Console.WriteLine();

        Console.WriteLine(numbers.Length);  //
    }
}
