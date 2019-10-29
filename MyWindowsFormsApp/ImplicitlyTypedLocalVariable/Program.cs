using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Model.Model;

namespace ImplicitlyTypedLocalVariable
{
    class Program
    {

        static void Main(string[] args)
        {
            int number;
            number = 10;
            var number2 = 20;

            string name = "Tapas";
            var name2 = "Rashed";

            var employee =  new Employee();
            var employees = new  List<Employee>();
        }
    }
}
