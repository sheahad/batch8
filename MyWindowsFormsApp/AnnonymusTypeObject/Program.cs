using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Model.Model;

namespace AnnonymusTypeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Ali",
                Address = "Mirpur"
            };

            //Console.WriteLine("Id: " + employee.Id + " Name:" + employee.Name + " Address: " + employee.Address);

            List<Employee> employees = new List<Employee>()
            {
                employee,
                new Employee(){Id=2, Name = "Ornob",Address= "Nikunjo-2"},
                new Employee(){Id=3, Name = "Arif",Address= "Uttora"},
            };


            var customer = new{Id = 1,Name = "Ali",Address = "Mirpur"};
            //customer.Id = 3;
            Console.WriteLine("Id: " + customer.Id + " Name:" + customer.Name + " Address: " + customer.Address);

            var i = new[] {1, 2, 3, 4};

            var customers = new []
            {
                new{Id = 2,Name = "Ali",Address = "Mohammadpur"},
                new{Id = 3,Name = "Alif",Address = "Uttora"},
                new{Id = 4,Name = "Abid",Address = "Mirpur"}
            };


            Show(customers);

            Console.ReadKey();
        }

        static void Show(dynamic customers)
        {
            foreach (var cust in customers)
            {
                Console.WriteLine("Id: " + cust.Id + " Name:" + cust.Name + " Address: " + cust.Address);
            }
        }
    }
}
