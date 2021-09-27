using System;

namespace Week3Q2
{
    public delegate void EventHandlerOperation(int a, int b);
    public class OperationCalculator
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("Addition: " + (x + y));
        }
        public static void Min(int x, int y)
        {
            Console.WriteLine("Subtraction: " + (x - y));
        }
        public void Times(int x, int y)
        {
            Console.WriteLine("Multiplication: " + (x * y));
        }
        public void Div(int x, int y)
        {
            Console.WriteLine("Division: " + (x / y));
        }

        static void Main(string[] args)
        {
            OperationCalculator operationCalculator = new OperationCalculator();
            EventHandlerOperation add = new EventHandlerOperation(Add);
            EventHandlerOperation min = new EventHandlerOperation(OperationCalculator.Min);
            EventHandlerOperation x = operationCalculator.Times;
            EventHandlerOperation div = new EventHandlerOperation(operationCalculator.Div); ;
            EventHandlerOperation invokeAll = add + min + x + div;

            Console.WriteLine("Enter 1st number");
            int input1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int input2 = Int32.Parse(Console.ReadLine());
            invokeAll.Invoke(input1, input2);
        }
    }
}
