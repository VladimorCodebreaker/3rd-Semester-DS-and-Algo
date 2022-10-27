using System;
using System.Text;
using System.Text.RegularExpressions;
using MoreLinq;
using MoreLinq.Extensions;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

namespace DS_and_Algo_5_Homework
{
    public class Dictionary
    {
        internal static Dictionary<string, int> Count(string file)
        {
            if (!File.Exists(file)) throw new FileNotFoundException();

            StreamReader reader = new StreamReader(file);
            var _out_txt = reader.ReadToEnd().ToLower(); // Read File

            Dictionary<string, int> dict = new Dictionary<string, int>();

            // Remove -> [Words]
            var stopWords = new Regex("^(the|and|or|with|the|of|before|after|at|on|an|a|by|this|that|he|her|she|his|it|theirs|its|their|for|those|from|to|between|among|i|you|we|us|them|mine|yours|your|in|out|him|they|me|my|mr|mrs|was|had|)$");
            var _out_word = String.Join(" ", _out_txt.Split().Where(x => !stopWords.IsMatch(x.Trim())));

            // Remove -> [Numbers]
            var _out_num = Regex.Replace(_out_word, @"[\d-]", string.Empty);

            // Remove -> [Roman Numbers]
            var txt = Regex.Replace(_out_num, " \b[xivXIV]+\b", string.Empty);

            // Remove -> [Chars]
            var charsToRemove = new char[] { ',', '.', ';', '-', '_', '@', '#', '*', '"', '/', '`', '´', ' ', '?', '€', '(', ')', '[', ']', '{', '}', '&', 'œ', '”' };
            var words = txt.Split().Select(x => x.Trim(charsToRemove)).ToArray();

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 1;
                }
                else
                {
                    int count = (int)dict[word];
                    count++;
                    dict[word] = count;
                }
            }

            return dict;
        }

        internal static Dictionary<string, int> Sort(Dictionary<string, int> dict)
        {
            var orderedDictionary = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return orderedDictionary;
        }

        internal static void Min(Dictionary<string, int> dict)
        {
            var min = dict.OrderBy(y => y.Value).Take(20);

            foreach (var element in min) Console.WriteLine(element);
        }

        internal static void Max(Dictionary<string, int> dict)
        {
            var max = dict.OrderByDescending(x => x.Value).Take(20);

            foreach (var element in max) Console.WriteLine(element);
        }

        internal static void Print(Dictionary<string, int> dict)
        {
            foreach (var element in dict)
            {
                Console.WriteLine("Key: " + element.Key + " Value: " + element.Value);
            }
        }
    }
}