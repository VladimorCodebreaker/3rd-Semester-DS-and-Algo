namespace DS_and_Algo_6;

class Program
{
    static void Main(string[] args)
    {
        var root = new Person()
        {
            Name = "ROOT",
            Children = new List<Person>()
            {
                new Person() {Name="Matthias Schmadlak", Gender='M'},
                new Person()
                {
                Name="Katherine Schmadlak",
                Gender='F',
                Children = new List<Person>()
                {
                    new Person() { Name="Albrecht Schmadlak", Gender='M'},
                    new Person()
                    {
                        Name = "Therese Magdalene Schmadlak",
                        Gender = 'F',
                        Children = new List<Person>()
                        {
                         new Person()
                         {
                             Name="Wolfgang Dieter Schmadlak",
                             Gender='M',
                         },
                         new Person()
                         {
                             Name="Svetlana Schmadlak",
                             Gender='F',
                             Children = new List<Person>()
                             {
                                    new Person()
                                     {
                                         Name="Wolfgang Vladimir Schmadlak",
                                         Gender='M'
                                     }
                                 }
                             }
                         }
                     }
                   }
                }
            }
        };

        ShowFamily(root, "Wolfgang");

        Console.WriteLine("\n\nPlease, just let me die :/");
    }

    private static void ShowFamily(Person a, string name)
    {
        ShowFamily(a, 0, name);
        FindName(a, 0, name);
    }

    private static void ShowFamily(Person a, int level, string name)
    {
        int count = 0;

        Console.WriteLine("".PadLeft(level * 4) + (a.Children.Any() ? "*" : "-") + a.Name);

        foreach (var c in a.Children)
        {
            ShowFamily(c, level + 1, name);
            count++;
        }

        Console.WriteLine("|" + count + "|");
    }

    private static List<string> FindName(Person a, int level, string name)
    {
        List<string> names = new List<string>();

        foreach (var c in a.Children)
        {
            if (c.Name.Contains(name))
            {
                Console.WriteLine("\n\n\n\n[Found " + c.Name + " at level " + level + "]\n\n");

                names.Add(name);
            }

            FindName(c, level + 1, name);
        }

        return names;
    }
}
