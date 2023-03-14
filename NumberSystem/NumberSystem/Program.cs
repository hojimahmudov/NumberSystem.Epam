using System;

class DecimalToBase
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: DecimalToBase <decimal_number> <base>");
            Environment.Exit(1);
        }

        int decimalNumber = int.Parse(args[0]);
        int newBase = int.Parse(args[1]);

        if (newBase < 2 || newBase > 20)
        {
            Console.WriteLine("Invalid base. Base must be between 2 and 20.");
            Environment.Exit(1);
        }

        string convertedNumber = ConvertDecimalToBase(decimalNumber, newBase);
        Console.WriteLine("{0} in base {1} = {2}", decimalNumber, newBase, convertedNumber);
    }

    static string ConvertDecimalToBase(int decimalNumber, int newBase)
    {
        string result = "";
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % newBase;
            if (remainder < 10)
            {
                result = remainder.ToString() + result;
            }
            else
            {
                char digit = (char)('A' + remainder - 10);
                result = digit + result;
            }
            decimalNumber /= newBase;
        }
        return result;
    }
}
