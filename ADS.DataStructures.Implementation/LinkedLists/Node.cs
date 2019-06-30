using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.DataStructure.Implementation.LinkedLists
{
    public class Node
    {
        public Node(int data)
        {
            Data = data;
            Next = null;
        }

        public int Data { get; set; }
        public Node Next { get; set; }
    }
}
