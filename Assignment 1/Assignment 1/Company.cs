using System;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace Assignment_1
{
    internal class Company
    {
        internal static Department Create()
        {
            var root = new Department("Leadership / Administration", "Noah", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) })
            {
                ListOfDepartments = new List<Department>()
                {
                    new Department("Finance", "Lena", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) })
                    {
                        ListOfDepartments = new List<Department>()
                        {
                            new Department("Expense Management", "Sascha", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() },
                            new Department("Tax", "Maria", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() },
                            new Department("Payroll", "Olaf", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() }
                        }
                    },
                    new Department("Marketing", "Maya", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) })
                    {
                        ListOfDepartments = new List<Department>()
                        {
                            new Department("Sales", "Johannes", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) })
                            {
                                ListOfDepartments = new List<Department>()
                                {
                                    new Department("Advertising", "Jens", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() },
                                    new Department("Credit / Collection", "Wolfgang", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator())})
                                    {
                                        ListOfDepartments = new List<Department>()
                                        {
                                            new Department("Debt", "Luna", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() },
                                        }
                                    },
                                }
                            },
                            new Department("Product Development", "Justus", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() },
                            new Department("Public Relations", "Phillip", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() }
                        }
                    },
                    new Department("Engineering", "Christen", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) })
                    {
                        ListOfDepartments = new List<Department>()
                        {
                            new Department("Research", "Lara", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() },
                            new Department("IT", "Susanne", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) })
                            {
                                ListOfDepartments = new List<Department>()
                                {
                                    new Department("Systems Infrastructure", "Isabelle", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() },
                                    new Department("Management", "Johanna", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) })
                                    {
                                        ListOfDepartments = new List<Department>()
                                        {
                                            new Department("Enterprise Architecture", "Kate", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() },
                                            new Department("Business Architecture", "Lorey", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>()},
                                        }
                                    },
                                    new Department("Information Security", "Anna", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() }
                                }
                            },
                            new Department("Development", "Sarah", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() }
                        }
                    },
                    new Department("Human Resources", "Bernd", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) })
                    {
                        ListOfDepartments = new List<Department>()
                        {
                            new Department("Recruiting", "Mara", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() },
                            new Department("Disciplinary", "Paul", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator())}) {ListOfDepartments = new List<Department>() },
                            new Department("Training / Onboarding", "Jasmin", new List<Employee>() { new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()), new Employee(RandomNameGenerator(), RandomNumberGenerator()) }) {ListOfDepartments = new List<Department>() }
                        }
                    }
                }
            };

            return root;
        }

        internal static string RandomNameGenerator()
        {
            Random random = new Random();
            string Name = "";

            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };

            Name += consonants[random.Next(consonants.Length)].ToUpper();
            Name += vowels[random.Next(vowels.Length)];

            int count = 2;

            while (count < random.Next(4, 10))
            {
                Name += consonants[random.Next(consonants.Length)];
                count++;

                Name += vowels[random.Next(vowels.Length)];
                count++;
            }

            return Name;
        }

        internal static int RandomNumberGenerator()
        {
            Random random = new Random();

            return random.Next(1, 1000);
        }
    }
}
