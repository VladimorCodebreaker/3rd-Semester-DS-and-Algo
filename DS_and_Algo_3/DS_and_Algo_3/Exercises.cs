using System;
namespace DS_and_Algo_3
{
    public class Exercises
    {
        internal static bool IsInRange(double n, double min, double max)
        {
            return (min <= n && n <= max);
        }

        internal static double Find(List<double> numbers, double min, double max)
        {
            if ((max < numbers[0]) || (min > numbers[numbers.Count - 1]))
            {
                return double.MinValue;
            }

            int lowIndex = 0;
            int highIndex = numbers.Count - 1;

            while (true)
            {
                if (highIndex - lowIndex == 1)
                {
                    if (IsInRange(numbers[highIndex], min, max))
                    {
                        return numbers[highIndex];
                    }
                    else if (IsInRange(numbers[lowIndex], min, max))
                    {
                        return numbers[lowIndex];
                    }
                    else
                    {
                        return double.MinValue;
                    }
                }

                int midIndex = (highIndex + lowIndex) / 2;
                double toTest = numbers[midIndex];

                if (IsInRange(toTest, min, max))
                {
                    return toTest;
                }
                if (toTest < min)
                {
                    lowIndex = midIndex;
                }
                else
                {
                    highIndex = midIndex;
                }
            }
        }
    }
}

