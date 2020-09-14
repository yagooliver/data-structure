using Stacks.ArrayLifo;
using Stacks.Linked;
using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //var stack = new ArrayStack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //Console.WriteLine($"Should print out 4: {stack.Peek()}");

            //stack.Pop();

            //Console.WriteLine($"Should print out 3: {stack.Peek()}");

            //Console.WriteLine("Iterate over the stack");

            //foreach(var cur in stack)
            //{
            //    Console.WriteLine(cur);
            //}
            var stack = new LinkedStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"Should print out 4: {stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"Should print out 3: {stack.Peek()}");

            Console.WriteLine("Iterate over the stack");

            foreach (var cur in stack)
            {
                Console.WriteLine(cur);
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
