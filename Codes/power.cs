using System;

class PowerCalculator
{
    public static int Power(int a, int b)
    {
        int result = 1;
        int baseValue = a;
        int exponent = b;

        while (exponent > 0)
        {
            result *= baseValue;
            exponent--;
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("2^5: " + Power(2, 5));
    }
}