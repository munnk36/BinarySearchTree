using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBinarySearchTree {
    public class MyLinkedBST {

        private Node root;

        /// <summary>
        /// wrapper for the recursive method _Print which traverses each node depth first and prints values
        /// </summary>
        public void Print() {
            Print(root);
        }

        //a recursive method which traverses each node starting left and going right. 
        //It prints the tree in sorted order.
        private void Print(Node root) {
            if (root.Left != null) {
                Print(root.Left);
            }
            Console.WriteLine(root.Data);
            if (root.Right != null) {
                Print(root.Right);
            }
        }

        public void Insert(params int[] values) {
            foreach (int value in values) {
                Node current = root;
                Node another = new Node();
                another.Data = value;
                if (root == null) {
                    root = another;
                    continue;
                }
                do {
                    if (value <= current.Data) {
                        if (current.Left == null) {
                            current.Left = another;
                            break;
                        }
                        current = current.Left;
                    } else {
                        if (current.Right == null) {
                            current.Right = another;
                            break;
                        }
                        current = current.Right;
                    }
                } while (true);
                another.Parent = current;
            }
        }

        //Remove finds the first instance of a Node with given data and removes all pointers to the Node.
        public void Remove(int data) {
            Node removing = Search(root, data);
            if (removing == null) {
                Console.WriteLine("No such value found.");
                return;
            } 
            Node parent = removing.Parent;
            Node right = removing.Right; //right child
            Node left = removing.Left; //left child
            if (removing.Left == null && removing.Right == null) {
                if (parent.Left == removing) {
                    parent.Left = null;
                    return;
                }
                parent.Right = null;
                return;
            } 
            
            if (removing.Left != null && removing.Right != null) {
                if (parent.Left == removing) {
                    parent.Left = right;
                } else {
                    parent.Right = right;
                }
                right.Parent = parent;
                int low = removing.Data + 1;
                Node Lowest = null;
                while (Lowest == null){
                    Lowest = Search(removing, low);
                }
                Lowest.Left = left;
                left.Parent = Lowest;
                return;
            }
            if (removing.Left == null) {
                right.Parent = removing.Parent;
                return;
            }
            left.Parent = removing.Parent;
        }

        //A public wrapper for _Search
        public Node Search(int data) {
            Node found = Search(root, data);
            if (found == null) {
                Console.WriteLine("Search for value was unsuccessful. Returned null.");
            }
            return found;
        }

        //Search recursively finds the first instance of a Node with given data and returns that Node.
        private Node Search(Node parental, int data) {
            Node left = parental.Left;
            Node right = parental.Right;
            if (parental.Data == data) {
                return parental;
            }
            
            if (data <= parental.Data && left != null) {
                return Search(left, data);
            }
            
            if (data > parental.Data && right != null) {
                return Search(right, data);
            }
            return null;
        }

        //int Pop() {
        //}
        //int Dequeue(int data) {
        //}
        //void ListFromFile(string path) {
        //}
    }
}