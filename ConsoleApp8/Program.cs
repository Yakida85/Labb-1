// Include namespace system
using System;
using System.IO;
using System.Numerics;

public class omar2
{

    public static void Main(String[] args)
    {
        string getText = omar2.getText();
        findsubStrings(getText);
        Console.WriteLine();
        Console.WriteLine("Total: " + getTotal().ToString());
    }

    public static BigInteger subResult = 0;
    
    private static String getText()
    {
        Console.WriteLine("Enter Input:");
        return Console.ReadLine();
    }
    private static void findsubStrings(String input)
    {
        for (int i = 0; i < input.Length; i++)
        {

            for (int k = i + 1; k < input.Length; k++)
            {
                if (char.IsLetter(input[k]))
                {
                    break;
                }
                else if (input[i] == input[k])
                {
                    string subP = input.Substring(i, k + 1 - i);
                    string startP = input.Substring(0, i);
                    int räkna = input.Length - k;
                    string endP = input.Substring(input.Length - räkna + 1);
                    omar2.addsubstring(subP);
                    omar2.toString(startP, subP, endP);

                    break;
                }
            }
        }
    }
    private static void addsubstring(String subNumbers)
    {
        var num = BigInteger.Parse(subNumbers);
        subResult += num;
    }
    private static BigInteger getTotal()
    {
        return omar2.subResult;
    }
    private static void toString(String start, String subString, String end)
    {
        Console.Write(start);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(subString);
        Console.ResetColor();
        Console.Write(end);
        Console.WriteLine();
    }

}
