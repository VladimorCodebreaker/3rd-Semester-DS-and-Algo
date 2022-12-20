using System.Drawing;
using System.Text;

namespace Assignment_3;

class Program
{
    static Menu Menu;

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Default;

        Menu = new Menu
        (
            "###################### Assignment 3 | ATM ######################",
            new[]
            {
                new Menu.Item("Get All Change", GetAllChange),
                new Menu.Item("Get Smallest Change", GetSmallestChange),
                new Menu.Item("Exit", Exit)
            }
        );

        Menu.Main.MaxColumns = 1;

        Menu.WriteLine("Use ←↑↓→ for navigation.");
        Menu.WriteLine("Press Esc to return to the main menu.");
        Menu.WriteLine("Press Backspace to return to the parent menu.");
        Menu.WriteLine("Press Del to clear the log.");

        Menu.Begin();
    }

    private static double[] denominations = { 0.01, 0.02, 0.05, 0.10, 0.20, 0.50, 1.00, 2.00 };

    static void GetAllChange()
    {
        Console.Clear();
        ATM.GetAllChange(ATM.GetInput(), 10, denominations.ToList(), new List<double>());
        Console.ReadKey();
    }

    static void GetSmallestChange()
    {
        Console.Clear();
        Console.WriteLine(ATM.GetSmallestChange(ATM.GetInput(), 10, denominations.Reverse().ToArray()));
        Console.ReadKey();
    }

    static void Exit()
    {
        Menu.Close();
    }
}
