using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStackUC1
{
    public class Node
    {
        public int data;
        public Node next;

        //constructor of Node class
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
