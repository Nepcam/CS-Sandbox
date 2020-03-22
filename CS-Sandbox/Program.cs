using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables

            int x = 2;
            Console.WriteLine("Number x is " + x);
            x = 5;
            Console.WriteLine("Number x is " + x);

            double double_num = 0.0d;
            float float_num = 0.0f;
            decimal decimal_num = 0.0m;

            double_num = 1.5d;
            float_num = 1.5f;
            decimal_num = 2.0m;

            Console.WriteLine("Double is " + double_num + " Float is " + float_num + " Decimal is " + decimal_num);

            string firstName, lastName, House;
            firstName = "Jon";
            lastName = " Snow";
            House = " House Stark";

            Console.WriteLine("Hello, " + firstName + lastName + " from -" + House);

            bool isWorking;
            isWorking = false;
            Console.WriteLine(isWorking);

            int sum;
            sum = 0;

            int number_1, number_2;

            number_1 = 50;
            number_2 = 100;
            sum = number_2 * number_1;
            Console.WriteLine(sum);

            //int x = 5;
            string name = "Cam";

            // Using the var variable
            var test = name;
            Console.WriteLine(test);

            //TypesConversion
            // Declare your variables in one place
            int serialNo = 100;
            string accountNo = "";
            float anyNo = 4.8f;

            // accountNo = serialNo; *** cannot convert 'int' to 'string' (use a conversion method see example below) ***
            accountNo = serialNo.ToString();
            Console.WriteLine(accountNo);

            // serialNo = anyNo; *** cannot convert 'float' to 'int'
            serialNo = Convert.ToInt32(anyNo);
            Console.WriteLine(serialNo);

            string message = "hello" + "world";
            Console.WriteLine(message);

            int n = 18 % 4;
            MessageBox.Show(n.ToString());

            const double PI = 3.14;
        }
    }
}
