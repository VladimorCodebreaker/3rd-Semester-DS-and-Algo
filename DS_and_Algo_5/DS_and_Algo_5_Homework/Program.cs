namespace DS_and_Algo_5_Homework;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dict0 = Dictionary.Count("/Users/vladimirschmadlak/Documents/Code/University/Semester 3/DS and Algo/DS_and_Algo_5/DS_and_Algo_5_Homework/CaptainBlood.txt");

        Dictionary<string, int> dict1 = Dictionary.Sort(dict0);

        Dictionary.Min(dict1);

        Console.WriteLine("\n\n");

        Dictionary.Max(dict1); 
    }
}

