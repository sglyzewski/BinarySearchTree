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


        public int Search(int dataToFind)
        {
            int nodesTraversed = 1;
            bool dataNotInTree = false;
            if (head == null)
            {
                return -1;
            }
            else
            {
                Node current = head;
                Console.WriteLine("\n\nSearch Path: for " + dataToFind + " from Head: ");
                Console.WriteLine("|" + head.data + "|");
                if (dataToFind < current.data && dataToFind != current.data)
                {
                    while (current.data != dataToFind)
                    {

                        while (current.left != null && current.data != dataToFind)
                        {
                            
                            current = current.left;
                            Console.WriteLine( "left: " + current.data);

                            nodesTraversed++;
                        }

                        while (current.right != null && current.data != dataToFind)
                        {
                            
                            current = current.right;
                            Console.WriteLine("right: " + current.data);

                            nodesTraversed++;
                        }

                        if (current.left == null && current.right == null && current.data != dataToFind)
                        {
                            dataNotInTree = true;
                            break;
                        }
                    }
                }

                if (dataToFind > current.data && dataToFind != current.data)
                {
                    while (current.data != dataToFind)
                    {
                        while (current.right != null && current.data != dataToFind)
                        {
                           
                            current = current.right;
                            Console.WriteLine("right: " + current.data);
                            nodesTraversed++;
                        }
                        while (current.left != null && current.data != dataToFind)
                        {
                            current = current.left;
                            Console.WriteLine("left: " + current.data);
                            nodesTraversed++;
                        }

                        if (current.left == null && current.right == null && current.data != dataToFind)
                        {
                            dataNotInTree = true;
                            break;
                        }

                    }
                }


                if (dataNotInTree)
                {
                    Console.WriteLine(dataToFind + " doesn't exist in the tree");
                }
                else {
                    Console.WriteLine("Arrived at " + dataToFind);
                    Console.WriteLine("Total nodes traversed " + nodesTraversed);
                }
                return nodesTraversed;
            }

        }
        


        
    }
}
