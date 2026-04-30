using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree1
{
    public class BinaryTreeNode<T>
    {
        public int Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }


        public BinaryTreeNode(int value)
        {
            Value = value;
            this.Left = null;
            this.Right = null;
        }
    }

    
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }

        //constructor to initialize the root of the tree
        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(T value)
        {
            //not need to return anything because we are modifying the tree in place
            if (Root == null)//if the tree is empty, create a new node and set it as the root
            {
                Root = new BinaryTreeNode<T>(Convert.ToInt32(value));
            }
            else
            {
                InsertRecursively(Root, Convert.ToInt32(value));
            }
        }

        private void InsertRecursively(BinaryTreeNode<T> node, int value)
        {
            if (value < node.Value)//inserted in left subtree
            {
                if (node.Left == null)//initialize the left child if it is null
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {//continue traversing the left subtree
                    InsertRecursively(node.Left, value);
                }
            }
            else
            {//inserted in right subtree
                if (node.Right == null)//initialize the right child if it is null
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {//continue traversing the right subtree
                    InsertRecursively(node.Right, value);
                }
            }
        }


        public void PrintTree()
        {
            PrintTreeRecursively(Root, 0);
        }

        private void PrintTreeRecursively(BinaryTreeNode<T> node, int level)
        {
            if (node != null)//base case: if the node is null, return
            {
                PrintTreeRecursively(node.Right, level + 1);
                Console.WriteLine(new string(' ', level * 4) + node.Value);
                PrintTreeRecursively(node.Left, level + 1);
            }
        }

        #region Traversal Tree 
        private void PreOrderTraversal(BinaryTreeNode<T> node)
        {
            if(node != null)
            {
                Console.Write(node.Value + "  ");
                PreOrderTraversal(node.Left);//traverse left subtree 
                PreOrderTraversal(node.Right);//traverse right subtree
            }
        }

        public void PreOrder()
        {
            Console.WriteLine();
            PreOrderTraversal(Root);
        }

        #endregion

        #region PostOrder Traversal
        private void PostOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);//traverse left subtree 
                PostOrderTraversal(node.Right);//traverse right subtree
                Console.Write(node.Value + "  ");
            }
        }

        public void PostOrder()
        {
            Console.WriteLine();
            PostOrderTraversal(Root);
        }

        #endregion
    }



    ////Mohamed AbuHadhoud Solution
    //public class BinaryTree<T>
    //{
    //    public BinaryTreeNode<T> Root { get; private set; } // The root node of the tree

    //    // Constructor initializing an empty tree
    //    public BinaryTree()
    //    {
    //        Root = null;
    //    }

    //    // Method to insert a new value into the tree
    //    public void Insert(T value)
    //    {

    //        /*
    //         We use Level-order insertion strategy,
    //         Level-order insertion: in a binary tree is a strategy that fills the tree level by level, 
    //         from left to right. This approach ensures that every level of the tree is completely 
    //         filled before any nodes are added to a new level, 
    //         and each parent node has at most two children before moving on to the next node in the 
    //         sequence.

    //         */

    //        var newNode = new BinaryTreeNode<T>(value); // Create a new node
    //        if (Root == null) // If the tree is empty, set the new node as the root
    //        {
    //            Root = newNode;
    //            return;
    //        }

    //        // Use a queue to perform level-order insertion
    //        Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
    //        queue.Enqueue(Root);

    //        while (queue.Count > 0)
    //        {
    //            var current = queue.Dequeue();

    //            // Attempt to insert the new node in the first empty spot in level order
    //            if (current.Left == null)
    //            {
    //                current.Left = newNode;
    //                break;
    //            }
    //            else
    //            {
    //                queue.Enqueue(current.Left);
    //            }

    //            if (current.Right == null)
    //            {
    //                current.Right = newNode;
    //                break;
    //            }
    //            else
    //            {
    //                queue.Enqueue(current.Right);
    //            }
    //        }
    //    }

    //    // Method to visually print the tree structure
    //    public void PrintTree()
    //    {
    //        PrintTree(Root, 0);
    //    }

    //    private void PrintTree(BinaryTreeNode<T> root, int space)
    //    {
    //        int COUNT = 10;  // Distance between levels to adjust the visual representation
    //        if (root == null)
    //            return;

    //        space += COUNT;
    //        PrintTree(root.Right, space); // Print right subtree first, then root, and left subtree last

    //        Console.WriteLine();
    //        for (int i = COUNT; i < space; i++)
    //            Console.Write(" ");
    //        Console.WriteLine(root.Value); // Print the current node after space

    //        PrintTree(root.Left, space); // Recur on the left child
    //    }
    //}


    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(2);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(8);

            tree.PrintTree();

            tree.PreOrder();

            tree.PostOrder();
        }
    }
}
