using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        private static List<int> numbers = Enumerable.Range(1, 50).ToList();
        static void Main(string[] args)
        {
            
            Calculator calculator = new Calculator();
            /*
            One thread, uncomment this code and comment the code below to see the difference.

            int Sum = calculator.Sum(numbers);
            int Multiplication = calculator.Multiplication(numbers);
            int Subtraction = calculator.Substraction(numbers);
            int Division = calculator.Division(numbers);
            */

            //Multithread
            Thread Sum = new Thread(() => calculator.Sum(numbers));
            Thread Multiplication = new Thread(() => calculator.Multiplication(numbers));
            Thread Subtraction = new Thread(() => calculator.Substraction(numbers));
            Thread Division = new Thread(() => calculator.Division(numbers));
            Sum.Name = "Sum";
            Multiplication.Name = "Multiplication";
            Subtraction.Name = "Subtraction";
            Division.Name = "Division";

            Sum.Start();
            Multiplication.Start();
            Subtraction.Start();
            Division.Start();
            
        }
    }
}
