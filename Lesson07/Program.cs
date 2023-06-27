using System;

class Test
{
    static void Main()
    {
        float horizontalKey = -0.02f;
        float xSpeed = 10;

        if (horizontalKey < 0)
        {
            if (xSpeed > 0)
            {
                Console.WriteLine("条件満たすやん");
            }
        }
    }
}