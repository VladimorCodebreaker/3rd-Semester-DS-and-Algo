using System;
using System.Linq;

namespace DS_and_Algo_5
{
    public class Exercises
    {  // codechef.com ??
       // Trees, Graphs
       // Dynamic Programming
        internal static Dictionary<string, string> Start()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();

            map.Add("txt", "Text File");
            map.Add("pdf", "Adobe PDF File");
            map.Add("exe", "Executable File");
            map.Add("docx", "Word File");
            map.Add("jpg", "JPG Image File");
            map.Add("png", "PNG Image File");

            return map;
        }

        internal static string FileRepresentation(Dictionary<string, string> map, string txt)
        {
            foreach (var key in map.Keys)
            {
                if (txt.Contains(key)) Console.WriteLine(map[key]);
                return "Idk what I'm doing".ToString();
            }

            return "";
        }
    }
}

