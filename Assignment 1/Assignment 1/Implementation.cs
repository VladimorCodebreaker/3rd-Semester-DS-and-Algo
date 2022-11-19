using System;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace Assignment_1
{
    public class Implementation
    {
        private int count_dep = 1;
        private int count_emp = 1;

        // --------------------------------- Department --------------------------------- //
        internal static void AddDepartment(Department root, string InsertAt, Department department)
        {
            var departmentToInsertAt = GetDepartment(root, InsertAt);

            if (departmentToInsertAt != null)
            {
                departmentToInsertAt.ListOfDepartments.Add(department);
            }
        }

        internal static Department RemoveDepartment(Department root, string name)
        {
            if (root.Name == name)
            {
                Console.WriteLine("\nYou are not allowed to dissolve the company! \n");
                Console.ReadKey();
            }

            root.ListOfDepartments.RemoveAll(x => x.Name == name);

            foreach (var child in root.ListOfDepartments)
            {
                child.ListOfDepartments.RemoveAll(x => x.Name == name);

                var department = RemoveDepartment(child, name);
                if (department != null) return department;
            }

            return null;
        }

        internal static void MoveDepartment(Department root, string position, string departmentToMove)
        {
            try
            {
                if (root.Name.Equals(departmentToMove))
                {
                    Console.WriteLine("\nYou do not have permission to modify the top-most department! Please try again! :( \n");
                    Console.ReadKey();
                    return;
                }
                else if (position == departmentToMove)
                {
                    return;
                }
                else
                {
                    var department = GetDepartment(root, departmentToMove);
                    RemoveDepartment(root, department.Name);
                    AddDepartment(root, position, department);
                }
            }
            catch { }
        }

        internal static Department GetDepartment(Department root, string name)
        {
            if (root.Name.Equals(name)) return root;

            foreach (var child in root.ListOfDepartments)
            {
                if (child.Name.Equals(name)) return child;

                var department = GetDepartment(child, name);
                if (department != null) return department;
            }

            return null;
        }

        internal static void PrintDepartment(Department root, int level)
        {
            Console.WriteLine("".PadLeft(level * 4) + (root.ListOfDepartments.Any() ? " * " : " - ") + root.Name);

            foreach (var child in root.ListOfDepartments)
            {
                PrintDepartment(child, level + 1);
            }
        }

        internal int CountDepartment(Department root)
        {
            foreach (var child in root.ListOfDepartments)
            {
                CountDepartment(child);
                count_dep++;
            }

            return count_dep;
        }

        // --------------------------------- Employee --------------------------------- //
        internal static void AddEmployee(Department root, string InsertAt, Employee employee)
        {
            var departmentToInsertAt = GetDepartment(root, InsertAt);

            if (departmentToInsertAt != null)
            {
                departmentToInsertAt.ListOfEmployees.Add(employee);
            }
        }

        internal static Department RemoveEmployee(Department root, string name)
        {
            root.ListOfEmployees.RemoveAll(x => x.Name == name);

            foreach (var child in root.ListOfDepartments)
            {
                child.ListOfEmployees.RemoveAll(x => x.Name == name);

                var department = RemoveEmployee(child, name);
                if (department != null) return department;
            }

            return null;
        }

        internal static void MoveEmployee(Department root, string position, string employeeToMove)
        {
            try
            {
                var employee = GetEmployee(root, employeeToMove);
                RemoveEmployee(root, employee.Name);
                AddEmployee(root, position, employee);
            }
            catch { }
        }

        internal static Employee GetEmployee(Department root, string name)
        {
            foreach (var child in root.ListOfEmployees)
            {
                if (child != null && child.Name == name) return child;
            }

            foreach (var child in root.ListOfDepartments)
            {
                foreach (var employee in child.ListOfEmployees)
                {
                    if (employee != null && employee.Name == name) return employee;
                }

                var department = GetEmployee(child, name);
                if (department != null) return department;
            }

            return null;
        }

        internal static void PrintEmployee(Department root, int level)
        {
            Console.WriteLine("".PadLeft(level * 4) + (root.ListOfDepartments.Any() ? " * " : " - ") + root.Name + "   | M: " + root.Manager.Name + " |  E: |-->> " + string.Join(", ", root.ListOfEmployees.Select(e => e.Name)));

            foreach (var child in root.ListOfDepartments)
            {
                PrintEmployee(child, level + 1);
            }
        }

        internal int CountEmployee(Department department)
        {
            foreach (var child in department.ListOfDepartments)
            {
                count_emp += child.ListOfEmployees.Count();
                count_emp++; // + Manager :)
                CountEmployee(child);
            }

            return count_emp + department.ListOfEmployees.Count;
        }

        internal int CountAllEmployees(Department root)
        {
            foreach (var child in root.ListOfDepartments)
            {
                count_emp += child.ListOfEmployees.Count();
                count_emp++; // + Manager :)
                CountAllEmployees(child);
            }

            return count_emp + root.ListOfEmployees.Count;
        }
    }
}
