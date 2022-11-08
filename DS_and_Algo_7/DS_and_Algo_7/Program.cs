using DS_and_Algo_7;

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

        //ShowFamily(root, "Wolfgang");

        //Console.WriteLine("\n\nPlease, just let me die :/");

        //BFS(root, "Wolfgang");
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
                Console.WriteLine("\n\n[Found " + c.Name + " at level " + level + "]");

                names.Add(name);
            }

            FindName(c, level + 1, name);
        }

        return names;
    }

    private static List<string> BFS(Person a, string name)
    {
        Queue<Person> people = new Queue<Person>();
        List<string> names = new List<string>();

        people.Enqueue(a);

        while (people.Count > 0)
        {
            Person current = people.Dequeue();
            Console.WriteLine(current.Name);

            if (current == null) continue;

            foreach (var child in current.Children)
            {
                if (child.Name.Contains(name))
                {
                    Console.WriteLine("\n\n[Found " + child.Name + "]\n\n");
                    names.Add(name);
                }

                people.Enqueue(child);
            }
        }

        foreach (var person in people)
        {
            Console.WriteLine(person);
        }

        return names;
    }
}