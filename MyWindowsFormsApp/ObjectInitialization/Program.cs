using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Model.Model;

namespace ObjectInitialization
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee ()
            {
                Id = 1,
                Name = "Ali",
                Address = "Mirpur"
            };

            Console.WriteLine("Id: " + employee.Id + " Name:" + employee.Name + " Address: " + employee.Address);

            List<Employee> employees = new List<Employee>()
            {
                employee,
                new Employee(){Id=2, Name = "Ornob",Address= "Nikunjo-2"},
                new Employee(){Id=3, Name = "Arif",Address= "Uttora"},
            };

            foreach (Employee emp in employees)
            {
                Console.WriteLine("Id: " + emp.Id + " Name:" + emp.Name + " Address: " + emp.Address);
            }
            
            Console.ReadKey();
        }
    }
}
