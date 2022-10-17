using System;

namespace DS_and_Algo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Commenty
            // Practice Lambda expressions
            // C# Homework in C++! ::  Big file -> Split file into several smaller pieces -> iterate over them -> sort them -> merge them
            // Binary search
            #endregion

            string[] all = File.ReadAllLines("/Users/vladimirschmadlak/Documents/Code/University/Semester 3/DS and Algo/DS_and_Algo_3/DS_and_Algo_3/numbers.txt");
            List<double> numbers = new List<double>();

            foreach (string s in all)
            {
                numbers.Add(double.Parse(s));
            }

            Console.WriteLine(Exercises.Find(numbers, 900, 900));
            Console.ReadKey();
        }
    }
}