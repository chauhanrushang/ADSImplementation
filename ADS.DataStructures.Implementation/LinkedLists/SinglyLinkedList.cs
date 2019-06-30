using System.Collections.Generic;

namespace ADS.DataStructure.Implementation.LinkedLists
{
    public class SinglyLinkedList
    {
        private Node start;
        public SinglyLinkedList()
        {
            start = null;
        }

        public void InsertAtTheBeginning(int data)
        {
            Node temp = new Node(data)
            {
                Next = start
            };
            start = temp;
        }

        public void InsertAtTheEnd(int data)
        {

            if (start == null)
            {
                start = new Node(data);
                return;
            }

            Node temp = start;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = new Node(data);
        }

        public void CreateList(IEnumerable<int> data)
        {
            foreach (int item in data)
            {
                InsertAtTheEnd(item);
            }
        }

        public void InsertAfter(int data, int x)
        {
            if (start == null)
            {
                start = new Node(data);
                return;
            }

            Node temp = start;

            while (temp.Next != null)
            {
                if (temp.Data == data)
                {
                    var node = new Node(data);
                    node.Next = temp.Next;
                    temp.Next = node;
                }
            }

        }

        public void InsertBefore(int data, int x)
        {

        }

        public void InsertAtPosition(int data, int p)
        {

        }
    }
}
