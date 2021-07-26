using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCupsOfCoffee = 1;
            string fullName = "Nam Pham";
            DateTime today = DateTime.Today;
            Console.WriteLine($"I drink {numberOfCupsOfCoffee} cup(s) of coffee everyday. My name is {fullName}. Today is {today}");

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hi {userName}!");

            Console.WriteLine("Enter two numbers");
            string firstNumberAsString = Console.ReadLine();
            string secondNumberAsString = Console.ReadLine();
            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);
            Console.WriteLine($"The two numbers you entered are {firstOperand} and {secondOperand}.");

            double sum = firstOperand + secondOperand;
            double difference = firstOperand - secondOperand;
            double product = firstOperand * secondOperand;
            double quotient = firstOperand / secondOperand;
            double remainder = firstOperand % secondOperand;

            Console.WriteLine($"Given the two numbers entered, their sum is {sum}, difference is {difference}, product is {product}, quotient is {quotient}, and remainder is {remainder}.");
        }
    }
}
