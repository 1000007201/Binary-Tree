using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBinaryTree
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> root;
        public BinaryTree()
        {
            root = null;
        }
        public void Insert(T data)
        {
            if (root == null)
            {
                root=new Node<T>(data);
                return;
            }
            else
            {
                InsertByRec(root, new Node<T>(data));
            }
        }
        public void InsertByRec(Node<T> root, Node<T> newnode)
        {
            if (root == null)
            {
                root = newnode;
            }
            if (root.NodeData.CompareTo(newnode.NodeData) > 0)
            {
                if (root.leftnode == null)
                {
                    root.leftnode = newnode;
                }
                else
                {
                    InsertByRec(root.leftnode,newnode);
                }
            }
            else
            {
                if (root.rightnode == null)
                {
                    root.rightnode = newnode;
                }
                else
                {
                    InsertByRec(root.rightnode,newnode);
                }
            }
        }
        private void DisplayTree(Node<T> root)
        {
            if (root == null) return;

            DisplayTree(root.leftnode);
            System.Console.Write(root.NodeData + " ");
            DisplayTree(root.rightnode);
        }
        public void DisplayTree()
        {
            DisplayTree(root);
        }


    }
}
