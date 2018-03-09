using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class SearchTree
    {
        public Node head;

        public SearchTree()
        {

        }

        public void Add(int dataToAdd)
        {
            Node nodeToAdd = new Node(dataToAdd);
            if (head == null)
            {
                head = nodeToAdd;
            }

            else
            {
                Node current = head;
                while (current.left != null && head.data > nodeToAdd.data)
                {
                    //// move from one node to the next node
                    //if (head.data > nodeToAdd.data)
                    //{
                        current = current.left;
                    //}
                }

                while (current.right != null && head.data < nodeToAdd.data) {

                    //if (head.data < nodeToAdd.data)
                    //{
                        current = current.right;
                    //}
                }
                


                if (head.data > nodeToAdd.data)
                {

                    current.left = nodeToAdd;
                }
                else if(head.data<nodeToAdd.data) {
                    current.right = nodeToAdd;
                }
            }
        }

        //public void Insert(int dataToAdd, int position)
        //{
        //    Node nodeToAdd = new Node(dataToAdd);

        //    if (position < 0)
        //    {
        //        Console.WriteLine("No tree exists to insert into!");
        //    }
        //    else
        //    {
        //        Node current = head;
        //        for (int i = 1; i < position; i++)
        //        {
        //            current = current.next;
        //        }
        //        Node temporaryNode = current.next;
        //        current.next = nodeToAdd;
        //        nodeToAdd.next = temporaryNode;
        //    }
        //}

        public void Print(Node current)
        {

            Console.WriteLine("|" + current.data + "|");
            
                if (current.left != null)
                {
                    Console.WriteLine("Moved Left: ");
                    Print(current.left);
                }

               if (current.right != null)
                {
                    Console.WriteLine("Moved Right:  ");
                    Print(current.right);
                }
         

        }

        public void PrintFromBeginning()
        {
            if (head != null)
            {
                Print(head);
            }
        }


        //public int SearchForInsert(int dataToFind)
        //{
        //    int nodesTraversed = 1;
        //    if (head == null)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        Node current = head;

        //        while (current.next != null && current.data != dataToFind)
        //        {
        //            nodesTraversed++;
        //            current = current.next;
        //        }
        //        return nodesTraversed;
        //    }

        //}
    }
}
