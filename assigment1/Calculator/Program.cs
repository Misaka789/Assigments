using System;
namespace assigment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] parameter = inputLine.Split(' ',
                StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            double double1 = double.Parse(parameter[0]);
            double double2 = double.Parse(parameter[2]);
            
            switch (parameter[1])
                {
                    case "+":
                    Console.Write(double1 + double2);
                        break;
                case "-":
                    Console.Write(double1 - double2);
                    break;
                case "*":
                    Console.Write(double1 * double2);
                    break;
                case "/":
                    Console.Write(double1 / double2);
                    break;
                case "%":
                    Console.Write(double1 % double2);
                    break;
            }
        }
    }
}
