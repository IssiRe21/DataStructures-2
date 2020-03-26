using System;

namespace data_structures_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(3);
            stack.Push(5);

            System.Console.WriteLine($"BottomElement => {stack.Bottom()}");

            stack.Push(7);
            
            System.Console.WriteLine($"TopElement => {stack.Top()}");

            stack.Push(11);

            System.Console.WriteLine(stack);

            int poppedElement;

            poppedElement = stack.Pop();
            System.Console.WriteLine($"poppedElement => {poppedElement}");
            System.Console.WriteLine(stack);

            poppedElement = stack.Pop();
            System.Console.WriteLine($"poppedElement => {poppedElement}");
            System.Console.WriteLine(stack);
            
             System.Console.WriteLine($"TopElement => {stack.Top()}");
            System.Console.WriteLine($"BottomElement => {stack.Bottom()}");
        }
    }
}