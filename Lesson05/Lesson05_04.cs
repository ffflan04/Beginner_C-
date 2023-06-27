// 例外処理を理解しよう
// C#プログラムの実行手順は、まず、
// コンピュータが理解できるコードにコンパイル、
// 順次、計算や処理を行う、実行。
// コンパイルエラー = 綴りの間違い、文法の間違いなど、
// 実行時エラー = 範囲外の配列にアクセスしたり、0で割り算する、対象のファイルがない など。
// 上記の、"実行時エラー"が、例外処理の対象です。
// try 予めコードを指定して、プログラム実行時に処理の問題を検出
// catch 問題を検出したとき、どのように対応するか記述しておく
// throw プログラム実行中に例外が発生したことを通知する。

// 例外が発生する例
// ゼロで割り算
// 数値変換で、数字でない文字を指定
// 配列の範囲外にアクセス
// ファイルが存在しない



// 簡単な例外処理をしてみよう！

using System;

public class Lesson10
{
    public static void Main()
    {
        Console.WriteLine("Hello World");

        try  // 例外を検出したいコード記述しています。
        {
            int number = 0;
            int answer = 100 / number;
            Console.WriteLine(answer);
        }
        catch (Exception e)  // 実際に例外が発生すると、Exceptionの"e"変数にエラーメッセージが代入されます。
        // catchのe変数は、例外の詳細情報を格納したexceptionオブジェクトになっています。
        {
            Console.WriteLine(e.Message);
            // exceptionオブジェクトのMessageプロパティを出力して発生した例外を説明するメッセージを出力しています。
        }
        finally  // 例外処理では必ず実行したいコードをfinallyブロックに記述します。
        {
            Console.WriteLine("Hello C#");
        }

    }
}
