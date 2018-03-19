using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBinarySearchTree {
    public class Node {
        private int data;
        private Node left;
        private Node right;
        private Node parent;

        public int Data {
            set {
                data = value;
            }
            get {
                return data;
            }
        }
        public Node Left {
            set {
                left = value;
            }
            get {
                return left;
            }
        }
        public Node Right {
            set {
                right = value;
            }
            get {
                return right;
            }
        }
        public Node Parent {
            set {
                parent = value;
            }
            get {
                return parent;
            }
        }
    }
}
