namespace Homework_1;

class Program
{
    static String sourceFile = "/Users/vladimirschmadlak/Documents/Code/University/Semester 3/DS and Algo/DS_and_Algo_3_Homework/Homework_1/numbers.txt";
    static String sortedFile = "/Users/vladimirschmadlak/Documents/Code/University/Semester 3/DS and Algo/DS_and_Algo_3_Homework/Homework_1/numbers.txt";
    public static int limit = 3999;
    static List<FileSegment> segments = new List<FileSegment>();
    static void Main(string[] args)
    {

        StreamReader reader = new StreamReader(sourceFile);
        string line = null;
        List<double> memorySegment = new List<double>();
        while (true)
        {
            line = reader.ReadLine();
            if (line == null)
            {
                if (memorySegment.Count > 0)
                {
                    segments.Add(new FileSegment(memorySegment));
                }
                break;
            }

            if (memorySegment.Count >= limit)
            {
                segments.Add(new FileSegment(memorySegment));
                memorySegment = new List<double>();
            }
            memorySegment.Add(double.Parse(line));
        }

        if (segments.Count > 1)
        {
            mergeSorted();
        }
    }

    static void mergeSorted()
    {
        List<double> nextInLine = new List<double>();
        StreamWriter writer = new StreamWriter(sortedFile);
        while (true)
        {
            nextInLine.Clear();
            foreach (FileSegment segment in segments)
            {
                nextInLine.Add(segment.Peek());
            }

            int minIndex = 0;
            double min = nextInLine[minIndex];
            for (int i = 1; i < nextInLine.Count; i++)
            {
                if (nextInLine[i] < min)
                {
                    min = nextInLine[i];
                    minIndex = i;
                }
            }

            if (min == double.MaxValue)
            {
                writer.Close();
                return;
            }

            writer.WriteLine(segments[minIndex].Get());
        }
    }
}