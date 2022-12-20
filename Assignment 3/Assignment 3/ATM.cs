using System;
using System.Drawing;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;

namespace Assignment_3
{
    public class ATM
    {
        internal static double GetInput()
        {
            while (true)
            {
                Console.WriteLine("#### How much change to return? #### \n====> Please Enter Total In Euro: \n");
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    if (result < 0)
                    {
                        Console.WriteLine("\nNegative change isn't a thing...Enter a positive number: \n");
                    }
                    else
                    {
                        Console.WriteLine();
                        return result;
                    }
                }
            }
        }

        internal static void GetAllChange(double amount, int maxCoins, List<double> denominations, List<double> combination)
        {
            if (amount < 0 || maxCoins == 0 || denominations.Count == 0) return;

            if (amount == 0)
            {
                if (combination.Count <= maxCoins)
                {
                    Console.WriteLine((string.Join("; ", combination)));
                }
                return;
            }

            List<double> copy = new List<double>(denominations);
            copy.RemoveAt(0);

            GetAllChange(amount, maxCoins, copy, combination);

            combination = new List<double>(combination) { denominations[0] };
            GetAllChange(amount - denominations[0], maxCoins, denominations, new List<double>(combination));

            return;
        }

        internal static string GetSmallestChange(double amount, int maxCoins, double[] denominations)
        {
            if (amount <= 0 || maxCoins <= 0 || denominations.Length == 0) return null;

            for (int i = 0; i < denominations.Length; i++)
            {
                if (denominations[i] == Math.Round(amount, 2))
                {
                    return denominations[i].ToString() + "; ";
                }
            }

            for (int i = 0; i < denominations.Length; i++)
            {
                if (denominations[i] > amount) continue;

                var res = GetSmallestChange(Math.Round(amount - denominations[i], 2), maxCoins - 1, denominations);

                if (res != null)
                {
                    return res + denominations[i].ToString() + "; ";
                }
            }

            return "The ATM does not have the provided change! Please enter a smaller amount...";
        }
    }
}
