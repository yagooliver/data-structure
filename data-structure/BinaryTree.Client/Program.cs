using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryTree.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var heap = new MaxHeap<int>();
            heap.Insert(24);
            heap.Insert(37);
            heap.Insert(17);
            heap.Insert(28);
            heap.Insert(31);
            heap.Insert(29);
            heap.Insert(15);
            heap.Insert(12);
            heap.Insert(20);

            // Console.WriteLine(heap.Peek());
            // Console.WriteLine(heap.Remove());
            // Console.WriteLine(heap.Peek());

            heap.Insert(40);
            heap.Sort();
            // Console.WriteLine();

            foreach(var i in heap.Values())
            {
                Console.Write($"{i} ");
            }
            Console.Read();

            var tree = new Bst<int>();
            tree.Insert(13);
            tree.Insert(2);
            tree.Insert(5);
            tree.Insert(16);
            tree.Insert(15);
            tree.Insert(20);
            tree.Insert(10);
            tree.Insert(7);
            
            foreach(var item in tree.TraverseInOrder())
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            tree.Remove(10);
            foreach(var item in tree.TraverseInOrder())
            {
                Console.Write($"{item} ");
            }

            Console.Read();
        }
    }
}
