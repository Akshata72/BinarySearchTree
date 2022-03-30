using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to binary search tree");
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(45);
            binarySearchTree.Insert(85);
            binarySearchTree.Insert(77);
            binarySearchTree.Insert(63);
            binarySearchTree.Insert(25);
            binarySearchTree.Insert(64);

            binarySearchTree.Display();
            binarySearchTree.Getsize();

            Console.WriteLine("------------------------");
            binarySearchTree.Search(63, binarySearchTree);
        }
    }
}