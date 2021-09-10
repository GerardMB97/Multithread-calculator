using System;
using System.Collections.Generic;
using System.Threading;

namespace MultiThreading
{
    public class Calculator
    {
        public int Sum(List<int> numbersArray)
        {
            int accumulator = 0;
            foreach(int number in numbersArray)
            {
                accumulator += number;
                Console.WriteLine("Summin...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Done summing...");
            return accumulator;
        }
        public int Multiplication(List<int> numbersArray)
        {
            int accumulator = 1;
            foreach(int number in numbersArray)
            {
                accumulator *= number;
                Console.WriteLine("Multiplying...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Done Multiplying...");
            return accumulator;
        }
        public int Substraction(List<int> numbersArray)
        {
            int accumulator = numbersArray[0];
            for (int i = 1; i<numbersArray.Count; i++)
            {
                accumulator -= numbersArray[i];
                Console.WriteLine("Subtracting...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Done Subtracting...");
            return accumulator;
        }
        public double Division(List<int> numbersArray)
        {
            double accumulator = numbersArray[0];
            for (int i = 1; i<numbersArray.Count; i++)
            {
                accumulator /= numbersArray[i];
                Console.WriteLine("Dividing...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Done Dividing...");
            return accumulator;
        }
    }
}
