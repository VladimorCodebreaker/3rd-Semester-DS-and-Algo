using System;

namespace DS_and_Algo_2
{
    public class Exercise<T>
    {
        internal static List<T> Task_1(List<T> listA, List<T> listB)
        {
            List<T> listC = new List<T> { };

            foreach (var element in listA)
            {
                int x = listB.IndexOf(element);

                if (x >= 0)
                {
                    listC.Add(element);
                }
            }

            return listC;
        }

        internal static void Print(List<T> list)
        {
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        } // Task 1

        internal static void Task_2(List<string> listOfNames)
        {
            listOfNames.Sort((a, b) => a.Length.CompareTo(b.Length));

            for (int i = 0; i < listOfNames.Count; i++)
            {
                Console.WriteLine(listOfNames[i]);
            }
        }

        internal static void Homework()
        {
            using (StreamReader sr = new StreamReader("/Users/vladimirschmadlak/Documents/Code/University/Semester 3/DS and Algo/DS_and_Algo_2/DS_and_Algo_2/SourceFile.txt"))
            {
                using (StreamWriter sw = new StreamWriter("/Users/vladimirschmadlak/Documents/Code/University/Semester 3/DS and Algo/DS_and_Algo_2/DS_and_Algo_2/DestinationFile.txt"))
                {
                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        string[] words = line.Split(' ');

                        if (words.Length >= 2000) continue;

                        sw.WriteLine(line);

                        line = sr.ReadLine();
                    }
                }

                Console.WriteLine("Execution successfully finished!");
            }
        }
    }
}

