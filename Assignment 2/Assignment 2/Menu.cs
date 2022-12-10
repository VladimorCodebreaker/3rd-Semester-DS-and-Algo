using System;

namespace Assignment_2
{
    public class Menu
    {
        internal static void Run()
        {
            Bulgaria.Create();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n############################ Road Trip Planner - Plan Your Next Adventure [Bulgaria] ############################\n\n" +
                    "====> Choose an option... \n" +
                    "0. Exit \n" +
                    "1. Quickest Path \n");

                bool userChoice = int.TryParse(Console.ReadLine(), out int choice);

                if (choice == 0) break;

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("### Where are you starting? ### \n");
                            Vertex source = Graph.GetVertex(Console.ReadLine());

                            Console.WriteLine("\n### Where are you going? ### \n");
                            Vertex destination = Graph.GetVertex(Console.ReadLine());

                            if (source != null && destination != null)
                            {
                                Console.WriteLine($"\n ====> The Fastest Route from {source.Name} to {destination.Name} is ====> \n");
                                Graph.QuickestPath(source, destination);
                                Graph.PrintQuickestPath(source, destination);

                                Console.WriteLine("\n\nPress a key to continue...\n");
                                Console.ReadKey();
                            }
                        }
                        catch { Console.WriteLine("\n\nInvalid input! Please try again. :( \n"); }
                        break;
                    default:
                        Console.WriteLine("\n Error. Please choose between 0 - 1 \n");
                        break;
                }
            }
            Console.WriteLine("\nThank you for visiting. I hope to get a high mark!! :)");
            Console.ReadKey();
        }
    }
}
