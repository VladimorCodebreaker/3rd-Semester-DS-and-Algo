using System;

namespace Homework_1
{
    public class FileSegment
    {
        static int nr = 0;

        /// <summary>
        /// The value of the static variable "nr" is gonna be shared among all instances of this class.
        /// So if we create and call several instances of this class, and create several files, we want
        /// the value to consistently increase, as in "file(++nr).txt, file(++nr).txt, file(++nr).txt
        /// ==> "file1.txt, file2.txt, file3.txt". This wouldn't be possible with variables without the "static"
        /// keyword, since the variable itself would reset with each instance of this class.
        /// </summary>

        string fileName = null;
        StreamReader reader;
        double nextInLine;

        public FileSegment(List<double> numbers)
        {
            numbers.Sort((a, b) => b.CompareTo(a)); // Descending order
            fileName = "/Users/vladimirschmadlak/Documents/Code/University/Semester 3/DS and Algo/DS_and_Algo_3_Homework/Homework_1/result" + (++nr) + ".txt";
            List<string> stringLines = new List<string>();
            foreach (double n in numbers)
            {
                stringLines.Add(n.ToString());
            }
            File.WriteAllLines(fileName, stringLines);
            reader = new StreamReader(fileName);
            nextInLine = double.Parse(reader.ReadLine());
        }

        public double Peek()
        {
            return nextInLine;
        }

        public double Get()
        {
            if (nextInLine == double.MaxValue) return nextInLine;

            double result = nextInLine;
            string line = reader.ReadLine();

            if ((line == null) || line.Trim().Equals("")) nextInLine = double.MaxValue;
            else nextInLine = double.Parse(line);

            return result;
        }
    }
}