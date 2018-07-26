using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Stuff_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 number1 = 0;
            Int32 number2 = 0;
            Int32 final = 0;
            String choice;

            Console.WriteLine("Welcome To My Calculator");
            Console.WriteLine("Please Enter The First Number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What Do You Want To Do With These Numbers?: (+, *, / or -)");
            choice = Console.ReadLine();
            Console.WriteLine("Please Enter The Second Number");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (choice == "+")
            {
                final = number1 + number2;
            } 

            if (choice == "-")
            {
                final = number1 - number2;
            }

            if (choice == "*")
            {
                final = number1 * number2;
            }

            if (choice == "/")
            {
                final = number1 / number2;
            }

            Console.WriteLine("The" + choice + "Was Applied");
            Console.WriteLine("The End Result is :{0}\n You Are Welcome \n", final);
            Console.WriteLine("Press Any Key To Continue.....");

            Console.ReadLine();


        }
    }
}
