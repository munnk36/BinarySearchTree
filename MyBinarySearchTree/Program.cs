using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBinarySearchTree {
    class Program {
        static void Main(string[] args) {
            MyLinkedBST Tree = new MyLinkedBST();
            List<int> inList = new List<int>();
            Tree.Insert(20, 21, 5, 2, 18);
            Tree.Print();
            Console.ReadLine();
            Tree.Remove(5);
            Tree.Print();
            Console.ReadLine();
        }
    }
}
