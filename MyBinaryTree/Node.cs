using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBinaryTree
{
    public class Node<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public Node<T> leftnode { get; set; }
        public Node<T> rightnode { get; set; }
        public Node(T data)
        {
            this.NodeData = data;
            this.leftnode = null;
            this.rightnode = null;
        }
    }
}
