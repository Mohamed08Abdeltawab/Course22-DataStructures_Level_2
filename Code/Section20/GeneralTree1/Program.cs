using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeneralTree1
{
    internal class Program
    {
        public class TreeNode<T>
        {
            public T Value { get; set; }
            public List<TreeNode<T>> Children { get; set; }

            //constructor
            public TreeNode(T value)
            {
                Value = value;
                Children = new List<TreeNode<T>>();
            }

            //method to add child
            public void AddChild(TreeNode<T> child)
            {
                Children.Add(child);//add element in the list of children
            }
        }

        public class Tree<T>
        {
            public TreeNode<T> Root { get; set; }//the root is first node 

            //constructor
            public Tree(T rootValue)
            {
                Root = new TreeNode<T>(rootValue);
            }
        }


        static void Main(string[] args)
        {
            var companyTree = new Tree<string>("CEO");//create a tree with root value "CEO"
            var finance = new TreeNode<string>("CFO");//create a node with value "CFO"
            var tech = new TreeNode<string>("CTO");//create a node with value "CTO"
            var marketing = new TreeNode<string>("CMO");//create a node with value "CMO"

            companyTree.Root.AddChild(finance);//add CFO as child of CEO
            companyTree.Root.AddChild(tech);//add CTO as child of CEO
            companyTree.Root.AddChild(marketing);//add CMO as child of CEO
            finance.AddChild(new TreeNode<string>("Accountant"));//add Accountant as child of CFO
            tech.AddChild(new TreeNode<string>("Developer"));//add Developer as child of CTO
            tech.AddChild(new TreeNode<string>("SysAdmin"));//add SysAdmin as child of CTO
            marketing.AddChild(new TreeNode<string>("Social Media Manager"));//add Social Media Manager as child of CMO


            PrintTree(companyTree.Root);//print the tree structure starting from the root
        }

        static void PrintTree<T>(TreeNode<T> node, string indent = "")
        {
            Console.WriteLine(indent + node.Value);
            foreach(var child in node.Children)//iterate all element in list
            {
                PrintTree(child, indent + "  ");//recursive call to print child nodes with increased indentation
            }
        }
    }
}
