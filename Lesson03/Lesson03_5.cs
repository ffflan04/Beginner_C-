// コンストラクタの存在意義について
// コンストラクタは、クラスの初期値を設定できる。
// コンストラクタは、クラスに引数を渡すための一つの手段である。
// 以下のコードのように、メソッドを実行する際に、引数を渡すこともできる。

using System;

public class Lesson07
{
    public static void Main()
    {
        var key = new MeaningExistence();  // コンストラクタで設定する引数はここ
        Console.WriteLine(key.Command("I"));  // 引数はここにも入力することができる
    }
}

public class MeaningExistence
{
    public string Command(string who)  // 変数を埋め込む
    {
        return who + " will need me";
    }
}
