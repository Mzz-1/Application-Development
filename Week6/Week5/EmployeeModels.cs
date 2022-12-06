using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Week6.Week5
{
    public class EmployeeModel
    {
        public static void Newlist()
        {

            List<Employee> list = new List<Employee>
            {
                new Employee{EmployeeName = "Rya Shrestha", Salary = 50000, Department = "IT"},
                new Employee{EmployeeName = "Nishi Maharjan", Salary = 40000, Department = "Marketing"},
                new Employee{EmployeeName = "Sonam Lama", Salary = 50000, Department = "IT"},
                new Employee{EmployeeName = "Saugat Sijapati", Salary = 30000, Department = "Marketing"},
                new Employee{EmployeeName = "Bidhan Bajracharya", Salary = 10000, Department = "Marketing"},
                new Employee{EmployeeName = "Aarya Rajbhandari", Salary = 50000, Department = "IT"},
                new Employee{EmployeeName = "Arnav Gorkhali", Salary = 70000, Department = "IT"},
                new Employee{EmployeeName = "Ronish Shrestha", Salary = 40000, Department = "Marketing"},
                new Employee{EmployeeName = "Aadesh Shrestha", Salary = 50000, Department = "IT"},
                new Employee{EmployeeName = "Pratham Maharjan", Salary = 80000, Department = "Marketing"},

            };
        

            Console.WriteLine("Enter Employee name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Employee department\n");
            var department = Console.ReadLine();
            Console.WriteLine($"Searching for {name} in the {department} department");
            List<Employee> searchList = list.Where(x => x.EmployeeName == name && x.Department == department).ToList();

            if (searchList.Exists(n => n.Department == department) == false)
            {
                Console.WriteLine("Department doesn't exist.");
            }
            else if (searchList.Exists(n => n.EmployeeName == name) == false){
                Console.WriteLine("Employee doesn't exist.");
            }

            foreach (var item in searchList)
            {
                Console.WriteLine("Employee Found:" + item.EmployeeName);
            }

            List<Employee> sortList = list.OrderBy(x => x.Salary).ToList();
            Console.WriteLine("\nSorting Employee according to salary\n");
            foreach (var item in sortList)
            {
                Console.WriteLine(item.EmployeeName + "\t\t\t" + item.Salary);
            }
            List<Employee> sortList1 = list.OrderByDescending(x => x.Salary).ToList();
            Console.WriteLine("\nSorting Employee according to salary(Descending)\n");
            foreach (var item in sortList1)
            {
                Console.WriteLine(item.EmployeeName + "\t\t\t" + item.Salary);
            }

            string filename = "serialized.json";
            string jsonString = JsonSerializer.Serialize(searchList);
            File.WriteAllText(filename, jsonString);
            Console.WriteLine(jsonString);
        }
    }
}