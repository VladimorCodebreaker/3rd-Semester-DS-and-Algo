using System.Linq;
using System.Text;

namespace DS_and_Algo_1;

class Program
{
    static void Main(string[] args)
    {
        //FloatingPointMemoryRepresentation();
        //Console.WriteLine(CapitalizedSentence("hello     my friend"));
        //Console.WriteLine(StringCutter("There is a bug with 8 legs in the database", 18));
        //RemoveNegativeNumbers();
    }

    private static void FloatingPointMemoryRepresentation()
    {
        double a = 183837474.08837000002;
        double b = 7373.0000056;
        double x1 = a / b * Math.PI;
        double x2 = a * Math.PI / b;

        Console.WriteLine("x1: " + x1);
        Console.WriteLine("x2: " + x2 + "\n");

        if (x1 == x2)
        {
            Console.WriteLine("equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }

        if (Math.Abs(x1 - x2) < 0.0001)
        {
            Console.WriteLine("Almost equal");
        }

        Console.ReadLine();
    }

    internal static string CapitalizedSentence(string input)
    {
        if (String.IsNullOrEmpty(input))
        {
            throw new ArgumentNullException("Oh no :/");
        }

        string[] splittedInput = input.Split(' ');
        string result = "";

        foreach (var word in splittedInput)
        {
            if (word.Trim() == string.Empty) continue; // useful

            result += char.ToUpper(word[0]) + word.Substring(1) + ' ';
        }

        return result;
    }

    internal static string StringCutter(string s, int len)
    {
        List<string> inappropriateWords = new List<string> { "Idiot", "Moron", "Sex" };

        foreach (var word in inappropriateWords)
        {
            var q = s.Contains(word);

            if (q == true)
            {
                Console.WriteLine("One more time, and I will ban you for idiotism!");
            }
        }

        if (string.IsNullOrEmpty(s))
        {
            throw new ArgumentNullException("ARGH!! I have to work tomorrow, dammit :(");
        }

        if (len <= 3 && len > 9999)
        {
            throw new ArgumentOutOfRangeException("Dammit. I'm hungry :)");
        }


        string[] words = s.Split(' ');
        StringBuilder sb = new StringBuilder();

        foreach (string word in words)
        {
            if (word.Trim() == string.Empty) continue;

            if (sb.Length + word.Length > len)
                break;

            sb.Append(' ');
            sb.Append(word);
        }

        return sb.ToString() + "...";
    }

    internal static void RemoveNegativeNumbers()
    {
        List<int> listInts = new List<int> { 1, 2, 3, 4, 5, 6, -3, -5, -6 };

        List<int> newList = listInts.Where(i => i >= 0).ToList();

        foreach (var element in newList)
        {
            Console.WriteLine(element);
        }
    }
}