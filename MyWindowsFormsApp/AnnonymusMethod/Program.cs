using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonymusMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Show();
            Action ShowAction = Show;
            ShowAction();

            ShowName("Kamal");
            Action<string> ShowNameAction = ShowName;
            ShowNameAction("Hasan");

            int result = 0;
            result = ReturnTen();
            Console.WriteLine("ReturnTen:" + result);

            Func<int> ReturnTenFunc = ReturnTen;
            result = ReturnTenFunc();
            Console.WriteLine("ReturnTenFunc:" + result);

            result = Add(5,6);
            Console.WriteLine("Add:" + result);

            Func<int,int,int> AddFunc = Add;
            result = AddFunc(5, 6);
            Console.WriteLine("AddFunc:" + result);

            Func<int, int, int> AddFunc2 = (a,b) =>
            {
                int r = a + b;
                return r;
            };
            result = AddFunc2(50, 6);
            Console.WriteLine("AddFunc2:" + result);

            result = Multiply(5, 6);
            Console.WriteLine("Multiply:" + result);


            Console.ReadKey();
        }

        static void Show()
        {
            Console.WriteLine("Method without Argumnet & Return Type");
        }

        static void ShowName(string name)
        {
            Console.WriteLine("Method without  Return Type");
            Console.WriteLine(name);
        }

        static int ReturnTen()
        {
            return 10;
        }


        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
