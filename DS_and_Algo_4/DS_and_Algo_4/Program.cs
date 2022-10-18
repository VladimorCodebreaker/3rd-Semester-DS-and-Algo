using System.Xml.Linq;

namespace DS_and_Algo_4;

class Program
{
    static void Main(string[] args)
    {
        // Check for brackets, using a stack
        //char[] sequence = new char[] { '(', '{', '[', ']', '}', ')' };
        //Stack<char> finalStack = new Stack<char>();

        //Console.WriteLine(Exercises.Checker(sequence, finalStack));

        // Reverse a list, using a stack
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Exercises.ReverseList(list, 0, list.Count - 1);
    }
}