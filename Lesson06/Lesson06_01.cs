// bool型について
// Console.WriteLineでbool型の真偽値を出力できる。
// bool型の変数宣言の初期値はfalse
// if (suiside) -> suiside == true という意味

using System;

public class UnityResolve
{
    public static void Main()
    {
        Seconds s = new Seconds();
        s.Authenticity();
        Console.WriteLine(s.Authenticity());
    }
}

public class Seconds
{

    public bool suiside = true;
    public bool reunion;
    public bool perhaps;
    public bool selection;

    public bool Authenticity()
    {
        if (suiside)
        {
            perhaps = true;
        }
        else if (reunion)
        {
            Console.WriteLine("デバッグテスト02");
        }
        return perhaps;
    }
}