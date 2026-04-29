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

            public TreeNode<T> Find(T value)
            {
                if (EqualityComparer<T>.Default.Equals(Value, value))
                    return this;

                foreach (var child in Children)
                {
                    var found = child.Find(value);
                    if (found != null)
                        return found;
                }

                return null; // Not found
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

            public void Print(string indent = "")
            {
                PrintTree(this.Root, indent);//call the method to print the tree starting from the root
            }

            private static void PrintTree(TreeNode<T> node, string indent = "")
            {
                Console.WriteLine(indent + node.Value);
                foreach (var child in node.Children)//iterate all element in list
                {
                    PrintTree(child, indent + "  ");//recursive call to print child nodes with increased indentation
                }
            }

            public TreeNode<T> Find(T value)
            {
                return Root?.Find(value);
            }


        }


        static void Main(string[] args)
        {
            #region Company Hierarchy Example

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

            #endregion

            #region Family Tree Example

            var _AliElhamed = new Tree<string>("Ali Abdelhamed");//create a node with value "Parent1"

            //children of Parent1
            var _AbdeltawabAli = new TreeNode<string>("Abdeltawab Ali");//create a node with value "Child1"
            var _AbdelhamedAli = new TreeNode<string>("Abdelhamed Ali");//create a node with value "Child2"
            var _MostafaAli = new TreeNode<string>("Mostafa Ali");//create a node with value "Child3"
            var _AhmedAli = new TreeNode<string>("Ahmed Ali");//create a node with value "Child4"
            var _MohamedAli = new TreeNode<string>("Mohamed Ali");//create a node with value "Child5"
            var _GadaAli = new TreeNode<string>("Gada Alie");//create a node with value "Child6"



            //add children to Ali Abdelhamed
            _AliElhamed.Root.AddChild(_AbdeltawabAli);
            _AliElhamed.Root.AddChild(_AbdelhamedAli);
            _AliElhamed.Root.AddChild(_MostafaAli);
            _AliElhamed.Root.AddChild(_AhmedAli);
            _AliElhamed.Root.AddChild(_MohamedAli);
            _AliElhamed.Root.AddChild(_GadaAli);

            //children of Abdletawab Ali
            _AbdeltawabAli.AddChild(new TreeNode<string>("Ali Abdeltawab Ali"));//create a node with value "Grandchild1"
            _AbdeltawabAli.AddChild(new TreeNode<string>("Shahed Abdeltawab Ali"));//create a node with value "Grandchild3"
            _AbdeltawabAli.AddChild(new TreeNode<string>("Mohamed Abdeltawab Ali"));//create a node with value "Grandchild2"
            _AbdeltawabAli.AddChild(new TreeNode<string>("Hager Abdeltawab Ali"));//create a node with value "Grandchild4"
            _AbdeltawabAli.AddChild(new TreeNode<string>("Malak Abdeltawab Ali"));//create a node with value "Grandchild5"

            //children of Abdelhamed Ali
            _AbdelhamedAli.AddChild(new TreeNode<string>("Tarek Abdelhamed Ali"));//create a node with value "Grandchild6"
            _AbdelhamedAli.AddChild(new TreeNode<string>("Shimaa Abdelhamed Ali"));//create a node with value "Grandchild7"
            _AbdelhamedAli.AddChild(new TreeNode<string>("Zinab Abdelhamed Ali"));//create a node with value "Grandchild7"
            _AbdelhamedAli.AddChild(new TreeNode<string>("Basma Abdelhamed Ali"));//create a node with value "Grandchild7"
            _AbdelhamedAli.AddChild(new TreeNode<string>("Marim Abdelhamed Ali"));//create a node with value "Grandchild7"

            //children of Mostafa Ali
            _MostafaAli.AddChild(new TreeNode<string>("Yousef Mostafa Ali"));//create a node with value "Grandchild8"
            _MostafaAli.AddChild(new TreeNode<string>("Ahmed Mostafa Ali"));//create a node with value "Grandchild8"
            _MostafaAli.AddChild(new TreeNode<string>("Ali Mostafa Ali"));//create a node with value "Grandchild8"
            _MostafaAli.AddChild(new TreeNode<string>("Maka Mostafa Ali"));//create a node with value "Grandchild8"
            _MostafaAli.AddChild(new TreeNode<string>("Khadiga Mostafa Ali"));//create a node with value "Grandchild8"

            //children of Ahmed Ali
            _AhmedAli.AddChild(new TreeNode<string>("Adam Ahmed Ali"));//create a node with value "Grandchild9"
            _AhmedAli.AddChild(new TreeNode<string>("Jana Ahmed Ali"));//create a node with value "Grandchild9"
            _AhmedAli.AddChild(new TreeNode<string>("Nada Ahmed Ali"));//create a node with value "Grandchild9"

            //children of Mohamed Ali
            _MohamedAli.AddChild(new TreeNode<string>("Zyad Mohamed Ali"));//create a node with value "Grandchild10"
            _MohamedAli.AddChild(new TreeNode<string>("Yara Mohamed Ali"));//create a node with value "Grandchild10"
            _MohamedAli.AddChild(new TreeNode<string>("Rana Mohamed Ali"));//create a node with value "Grandchild10"
            _MohamedAli.AddChild(new TreeNode<string>("Abdo Mohamed Ali"));//create a node with value "Grandchild10"

            //children of Gada Ali
            _GadaAli.AddChild(new TreeNode<string>("Rihab Gada Ali"));//create a node with value "Grandchild11"
            _GadaAli.AddChild(new TreeNode<string>("Mohamed Gada Ali"));//create a node with value "Grandchild11"
            _GadaAli.AddChild(new TreeNode<string>("Ahmed Gada Ali"));//create a node with value "Grandchild11"
            _GadaAli.AddChild(new TreeNode<string>("Ibrahim Gada Ali"));//create a node with value "Grandchild11"




            #endregion


            #region Finding a Node Example
            // Printing the tree
            companyTree.Print();

            Console.WriteLine("\nFinding Developer...");
            if (companyTree.Find("Developer") == null)
                Console.WriteLine("Not Found :-(");
            else
                Console.WriteLine("Found :-)");

            Console.WriteLine("\nFinding DBA...");
            if (companyTree.Find("DBA") == null)
                Console.WriteLine("Not Found :-(");
            else
                Console.WriteLine("Found :-)");

            #endregion
        }


    }
}
