using System;

namespace data_structures_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            
            int? poppedElement;
            poppedElement = stack.Pop();
            System.Console.WriteLine($"poppedElement => {poppedElement}");

            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Push(11);

            System.Console.WriteLine(stack);

            poppedElement = stack.Pop();
            System.Console.WriteLine($"poppedElement => {poppedElement}");
            System.Console.WriteLine(stack);

            poppedElement = stack.Pop();
            System.Console.WriteLine($"poppedElement => {poppedElement}");
            System.Console.WriteLine(stack);

            //33, 12, 45, 10, 7, 89

            Queue queue = new Queue();

            System.Console.WriteLine(queue);

            // int? currentFront = queue.Front();
            // if (currentFront is int currentFrontInt)
            // {
            //     System.Console.WriteLine("It has a value!");
            // } else {
            //     System.Console.WriteLine("No value!");
            // }

            System.Console.WriteLine($"queue.Front() => {queue.Front()}");
            System.Console.WriteLine($"queue.Rear() => {queue.Rear()}");

            queue.Enqueue(33);

            System.Console.WriteLine(queue);

            System.Console.WriteLine($"queue.Front() => {queue.Front()}");
            System.Console.WriteLine($"queue.Rear() => {queue.Rear()}");

            queue.Enqueue(12);
            queue.Enqueue(45);
            queue.Enqueue(10);
            queue.Enqueue(7);
            queue.Enqueue(89);

            System.Console.WriteLine(queue);

            System.Console.WriteLine($"queue.Front() => {queue.Front()}");
            System.Console.WriteLine($"queue.Rear() => {queue.Rear()}");


            System.Console.WriteLine($"queue.Dequeue() => {queue.Dequeue()}");
            System.Console.WriteLine($"queue.Dequeue() => {queue.Dequeue()}");

            System.Console.WriteLine(queue);

            System.Console.WriteLine($"queue.Front() => {queue.Front()}");
            System.Console.WriteLine($"queue.Rear() => {queue.Rear()}");
        }
    }
}
