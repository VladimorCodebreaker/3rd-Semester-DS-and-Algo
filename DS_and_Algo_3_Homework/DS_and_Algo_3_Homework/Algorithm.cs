using System;

namespace DS_and_Algo_3_Homework
{
    public class Algorithm
    {
        internal static void Get()
        {
            Department department1 = new Department("1", 50, "Valentin");
            Department department2 = new Department("2", 60, "Lara");
            Department department3 = new Department("3", 40, "Lena");
            Department department4 = new Department("4", 670, "Samuel");
            Department department5 = new Department("5", 9, "Phillip");
            Department department6 = new Department("6", 66, "Simon");
            Department department7 = new Department("7", 55, "Andreas");

            List<Department> departments = new List<Department>() { department1, department2, department3, department4, department5, department6, department7 };

            Sort(departments);
        }

        internal static List<Department> Sort(List<Department> list)
        {
            list.Sort((a, b) => a.NumberOfEmployees.CompareTo(b.NumberOfEmployees));

            Print(list);
            return list;
        }

        internal static void Print(List<Department> list)
        {
            foreach (var element in list)
            {
                Console.WriteLine("Number of Employees  |  " + element.NumberOfEmployees + "  |" + "    Name: " + element.Name + "   Manager: " + element.Manager.Name);
            }
        }
    }
}

