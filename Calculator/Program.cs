using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to our basic calculator");
            var stay = true;
            
            do
            {
                Console.WriteLine("Menu");
                System.Console.WriteLine("Press 1 for Addition");
                System.Console.WriteLine("Press 2 for Subtraction");
                System.Console.WriteLine("Press 3 for Multiplication");
                System.Console.WriteLine("Press 4 for Division");
                System.Console.WriteLine("Press 5 for Exit");

                var choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        //var input1 = (double)Console.ReadLine(); //explicit casting with exception
                        //var input2 = Console.ReadLine() as double; //explicit casting with null

                        var input1 = double.Parse(Console.ReadLine()); //explicit parsing with 0
                        double input2;
                        double.TryParse(Console.ReadLine(), out input2); //explicit parsing with exception

                        Add(input1, input2);
                        break;
                    case "2":
                        var input3 = double.Parse(Console.ReadLine());
                        double input4;
                        double.TryParse(Console.ReadLine(), out input4);

                        Subtract(input3, input4);
                        break;
                    case "3":
                        var input5 = double.Parse(Console.ReadLine());
                        double input6;
                        double.TryParse(Console.ReadLine(), out input6);

                        Multiply(input5, input6);
                        break;
                    case "4":
                        var input7 = double.Parse(Console.ReadLine());
                        double input8;
                        double.TryParse(Console.ReadLine(), out input8);

                        Divide(input7, input8);
                        break;
                    default:
                        stay = false;
                        break;
                }
            }while(stay);
        }

        static void Add(double operand1, double operand2)
        {
            var result = operand1 + operand2;
            System.Console.WriteLine($"your answer is: {result}");
        }
        static void Subtract(double operand1, double operand2)
        {
            var result = operand1 - operand2;
            System.Console.WriteLine($"your answer is: {result}");
        }
        static void Multiply(double operand1, double operand2)
        {
            var result = operand1 * operand2;
            System.Console.WriteLine($"your answer is: {result}");
        }
        static void Divide(double operand1, double operand2)
        {
            var result = operand1 / operand2;
            System.Console.WriteLine($"your answer is: {result}");
        }
    } 
}
