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
        public SearchTree child;

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
            
                if (head.data > nodeToAdd.data)
                {
                    while (current.left != null && current.right != null)
                    {
                        //traverse down left side until you can't go left anymore
                        while (current.left != null)
                        {
                            current = current.left;
                        }
                        //traverse down right until you can't anymore
                        while (current.right != null)
                        {
                            current = current.right;
                        }
                    }

                    if (current.data > nodeToAdd.data)
                        {
                            current.left = nodeToAdd;
                        }
                        else if (current.data < nodeToAdd.data)
                        {
                            current.right = nodeToAdd;
                        }
                    

                }

                else if (head.data < nodeToAdd.data)
                {
                    while (current.left != null && current.right != null)
                    {
                        while (current.right != null)
                        {
                            current = current.right;
                        }
                        while (current.left != null)
                        {
                            current = current.left;
                        }
                    }

                    if (current.data > nodeToAdd.data)
                        {
                            current.left = nodeToAdd;
                        }
                        else if (current.data < nodeToAdd.data)
                        {
                            current.right = nodeToAdd;
                        }
                    

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
