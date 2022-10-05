using System.Collections.Generic;

namespace HelloWorldProject.Models
{
    public class Repository
    {
        private static List<Employee> employeeList = new List<Employee>();

        public static IEnumerable<Employee> GetEmployees()
        {
            return employeeList;
        }

        public static void addEmployee(Employee emp)
        {
            employeeList.Add(emp);
        }
    }
}
