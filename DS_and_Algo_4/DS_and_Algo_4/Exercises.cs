using System;

namespace DS_and_Algo_4
{
    public class Exercises
    {
        internal static bool Checker(char[] sequence, Stack<char> finalStack)
        {
            foreach (var element in sequence)
            {
                if (element == '(' || element == '[' || element == '{')
                {
                    finalStack.Push(element);
                }
                else if (element == ')' || element == ']' || element == '}')
                {
                    if (finalStack.Count == 0) return false;

                    var topString = finalStack.Pop();
                    var str = $"{topString}{element}";

                    if (str != "[]" && str != "{}" && str != "()") return false;
                }
                else return false;
            }

            return true;
        }

        internal static void ReverseList(List<int> list, int start, int end)
        {
            if (list.Count == 0 || list.Count == 1) throw new InvalidDataException();
            if (start >= end)
            {
                foreach (var element in list) Print(element);
                return;
            }

            int temp = list[start];
            list[start] = list[end];
            list[end] = temp;

            ReverseList(list, start + 1, end - 1);
        }

        private static void Print(int element) => Console.WriteLine(element);
    }
}

