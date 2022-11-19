using System;

namespace Assignment_1
{
    public class Menu
    {
        internal static void Run()
        {
            var root = Company.Create();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n------------------------------ Company -------------------------------\n\n" +
                    "====> Choose an option... \n" +
                    "0. Exit \n" +
                    "1. Display \n" +
                    "2. Get \n" +
                    "3. Add \n" +
                    "4. Remove \n" +
                    "5. Move \n" +
                    "6. Count \n");

                bool userChoice = int.TryParse(Console.ReadLine(), out int choice);

                if (choice == 0)
                {
                    break;
                }

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("[Display] ====> Choose an option... \n===> \n1. Company \n2. Employees \n");
                        bool input_1 = int.TryParse(Console.ReadLine(), out int option_1);

                        Console.Clear();

                        if (option_1 == 1)
                        {
                            Console.WriteLine("\n\n############################## Organizational Structure [Company] ################################## \n");
                            Implementation.PrintDepartment(root, 0);
                            Console.WriteLine("\n\nPress a key to continue...\n");
                            Console.ReadKey();
                        }
                        else if (option_1 == 2)
                        {
                            Console.WriteLine("\n\n############################## Organizational Structure [Employees] ################################## \n");
                            Implementation.PrintEmployee(root, 0);
                            Console.WriteLine("\n\nPress a key to continue...\n");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Error 503. Option not available. Choose between 1 - 2 \n");
                        }
                        break;
                    case 2:
                        Console.WriteLine("[Get] ====> Choose an option... \n===> \n1. Department \n2. Employee \n");
                        bool input_2 = int.TryParse(Console.ReadLine(), out int option_2);

                        Console.Clear();

                        if (option_2 == 1)
                        {
                            Console.WriteLine("Please enter a name: \n");
                            string name_1 = Console.ReadLine();

                            if (!String.IsNullOrEmpty(name_1))
                            {
                                try
                                {
                                    Console.WriteLine(Implementation.GetDepartment(root, name_1).ToString());
                                }
                                catch { Console.WriteLine("\n\nInvalid input! Please try again. :( \n"); }
                                Console.WriteLine("\n\nPress a key to continue...\n");
                                Console.ReadKey();
                            }
                        }
                        else if (option_2 == 2)
                        {
                            Console.WriteLine("Please enter a name: \n");
                            string name_1 = Console.ReadLine();

                            if (!String.IsNullOrEmpty(name_1))
                            {
                                try
                                {
                                    Console.WriteLine(Implementation.GetEmployee(root, name_1).ToString());
                                }
                                catch { Console.WriteLine("\n\nInvalid input! Please try again. :( \n"); }
                                Console.WriteLine("\n\nPress a key to continue...\n");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nError 503. Option not available. Choose between 1 - 2 \n");
                        }
                        break;
                    case 3:
                        Console.WriteLine("[Add] ====> Choose an option... \n===> \n1. Department \n2. Employee \n");
                        bool input_3 = int.TryParse(Console.ReadLine(), out int option_3);

                        Console.Clear();

                        if (option_3 == 1)
                        {
                            Console.WriteLine("Please specify the position [Department] you want to add the department to: \n");
                            var insertAt_1 = Console.ReadLine();

                            var department = CreateDepartment();

                            if (!String.IsNullOrEmpty(insertAt_1))
                            {
                                Implementation.AddDepartment(root, insertAt_1, department);
                            }
                            else
                            {
                                Console.WriteLine("\nYou forgot to add a position. Please try again! :( \n");
                                Console.ReadKey();
                            }
                        }
                        else if (option_3 == 2)
                        {
                            Console.WriteLine("Please specify the position [Department] you want to add the employee to: \n");
                            var insertAt_2 = Console.ReadLine();

                            var employee = CreateEmployee();

                            if (!String.IsNullOrEmpty(insertAt_2))
                            {
                                Implementation.AddEmployee(root, insertAt_2, employee);
                            }
                            else
                            {
                                Console.WriteLine("\nYou forgot to add to add a position. Please try again! :( \n");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error 503. Option not available. Choose between 1 - 2 \n");
                        }
                        break;
                    case 4:
                        Console.WriteLine("[Remove] ====> Choose an option... \n===> \n1. Department \n2. Employee \n");
                        bool input_4 = int.TryParse(Console.ReadLine(), out int option_4);

                        Console.Clear();

                        if (option_4 == 1)
                        {
                            Console.WriteLine("Please enter a name [department] => : \n");
                            string name_2 = Console.ReadLine();

                            if (!String.IsNullOrEmpty(name_2))
                            {
                                Implementation.RemoveDepartment(root, name_2);
                            }
                            else
                            {
                                Console.WriteLine("\nIt seems you forgot to enter a name. Please try again! :( \n");
                                Console.ReadKey();
                            }
                        }
                        else if (option_4 == 2)
                        {
                            Console.WriteLine("Please enter a name [employee] => : \n");
                            string name_2 = Console.ReadLine();

                            if (!String.IsNullOrEmpty(name_2))
                            {
                                Implementation.RemoveEmployee(root, name_2);
                            }
                            else
                            {
                                Console.WriteLine("\nIt seems you forgot to enter a name. Please try again! :( \n");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error 503. Option not available. Choose between 1 - 2 \n");
                        }
                        break;
                    case 5:
                        Console.WriteLine("[Move] ====> Choose an option... \n===> \n1. Department \n2. Employee \n");
                        bool input_5 = int.TryParse(Console.ReadLine(), out int option_5);

                        Console.Clear();

                        if (option_5 == 1)
                        {
                            Console.WriteLine("Please specify the position [department] to move the element to: \n");
                            string position = Console.ReadLine();

                            Console.WriteLine("\nPlease enter the name of the element [department] to move: \n");
                            string element = Console.ReadLine();

                            if (!String.IsNullOrEmpty(position) && !String.IsNullOrEmpty(element))
                            {
                                Implementation.MoveDepartment(root, position, element);
                            }
                            else
                            {
                                Console.WriteLine("\nIt seems you forgot to enter a value. Please try again! :( \n");
                                Console.ReadKey();
                            }
                        }
                        else if (option_5 == 2)
                        {
                            Console.WriteLine("Please specify the position [department] to move the element to: \n");
                            string position = Console.ReadLine();

                            Console.WriteLine("\nPlease enter the name of the element [employee] to move: \n");
                            string element = Console.ReadLine();

                            if (!String.IsNullOrEmpty(position) && !String.IsNullOrEmpty(element))
                            {
                                Implementation.MoveEmployee(root, position, element);
                            }
                            else
                            {
                                Console.WriteLine("\nIt seems you forgot to enter a value. Please try again! :( \n");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error 503. Option not available. Choose between 1 - 2 \n");
                        }
                        break;
                    case 6:
                        Implementation implementation = new Implementation();

                        Console.WriteLine("[Count] ====> Choose an option... \n===> \n1. Departments \n2. Employees [Company] \n3. Employees [In a specific department + all it's descending children] \n");
                        bool input_6 = int.TryParse(Console.ReadLine(), out int option_6);

                        if (option_6 == 1)
                        {
                            Console.WriteLine("\nCount of [Department] => " + implementation.CountDepartment(root) + "\n");
                            Console.ReadKey();
                        }
                        else if (option_6 == 2)
                        {
                            Console.WriteLine("\nCount of [Employee] => " + implementation.CountAllEmployees(root) + "\n");
                            Console.ReadKey();
                        }
                        else if (option_6 == 3)
                        {
                            Console.WriteLine("\nPlease enter a name [department] => : \n");
                            string name = Console.ReadLine();

                            if (!String.IsNullOrEmpty(name))
                            {
                                var department = Implementation.GetDepartment(root, name);
                                if (department != null)
                                {
                                    Console.WriteLine("\nCount of [Employee] => " + implementation.CountEmployee(department) + "\n");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("\nThe object was not found. Please try again! :( \n");
                                    Console.ReadKey();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error 503. Option not available. Choose between 1 - 2 \n");
                        }
                        break;
                    default:
                        Console.WriteLine("\nError. Please choose between 0 - 6 \n");
                        break;
                }
            }
            Console.WriteLine("Thank you for visiting. I hope to get a high mark!! :)");
            Console.ReadKey();
        }

        private static Department CreateDepartment()
        {
            Console.WriteLine("\nCreate Department - Form\n");

            Console.WriteLine("[string] => Name: \n");
            string name = Console.ReadLine();

            Console.WriteLine("\n[string] => Manager: \n");
            string manager = Console.ReadLine();

            var listOfEmployees = new List<Employee>() { new Employee(Company.RandomNameGenerator(), Company.RandomNumberGenerator()), new Employee(Company.RandomNameGenerator(), Company.RandomNumberGenerator()), new Employee(Company.RandomNameGenerator(), Company.RandomNumberGenerator()) };

            if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(manager))
            {
                return new Department(name, manager, listOfEmployees) { ListOfDepartments = new List<Department>() };
            }
            else
            {
                Console.WriteLine("\n\nThe department was not added. Please enter valid values! :( \n");
                Console.ReadKey();
            }

            return null;
        }

        private static Employee CreateEmployee()
        {
            Console.WriteLine("\nCreate Employee - Form\n");

            Console.WriteLine("[string] => Name: \n");
            string name = Console.ReadLine();

            Console.WriteLine("\n[int] => ID: \n");

            bool input = int.TryParse(Console.ReadLine(), out int empID);

            if (!String.IsNullOrEmpty(name) && empID > 0)
            {
                return new Employee(name, empID);
            }
            else
            {
                Console.WriteLine("\n\nThe employee was not added. Please enter valid values! :( \n");
                Console.ReadKey();
            }

            return null;
        }
    }
}
