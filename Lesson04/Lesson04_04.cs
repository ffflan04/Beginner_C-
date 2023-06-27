// 標準ライブラリと、listクラス
// 名前空間(namespace)で管理されてる
// クラスで構成されている
// C# では、名前空間を使ってクラスを管理します。
// 定義されてるクラスの一覧
// System 名前空間 = { Array, Console, Exception, Math, Random }
// System.IO 名前空間 = { File, Fileinfo, FileStream, Directory, Path }
// 名前空間で定義されてるメソッドを呼び出すには、
// System.Console.WriteLine("HelloWorld");
// 名前空間.クラス.メソッド の順番でドットで区切って記述します。
// usingキーワードで予め使う名前空間を定義すると、メソッドを呼び出す際に、
// 定義した名前空間の記述を省略することが可能になる。

using System;
using System.Collections.Generic; // listクラスの名前空間

class Lesson08
{
    public static void Main()
    {
        var team = new List<string>();
        // listクラスからオブジェクトを作成できました。
        // listクラスを作成するときには、このように、
        // 構成する要素の型を指定するんでしたよね。
        // こういったオブジェクトを作成する際に、
        // 型を指定するクラスのことをジェネリッククラスと呼びます。
        // 通常の配列だと、リストのような柔軟な要素の操作はできない。
        team.Add("勇者");
        team.Add("戦士");
        team.Add("魔法使い");
        // これでteamオブジェクトに文字列を追加することができました。
        // listクラスにはaddメソッドが用意されていて、

        foreach (var member in team)
        {
            Console.WriteLine(member);
        }

        Console.WriteLine();

        team.Insert(2, "忍者"); // Insertメソッドを使うと指定した位置にオブジェクトを挿入できます。
        foreach (var member in team)
        {
            Console.WriteLine(member);
        }

        Console.WriteLine();
        team.Remove("戦士");
        foreach (var member in team)
        {
            Console.WriteLine(member);
        }
    }
}

