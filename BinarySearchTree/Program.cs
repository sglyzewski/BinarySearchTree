using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchTree tree = new SearchTree();
            tree.Add(100);
            tree.Add(115);
            tree.Add(50);
            tree.Add(25);
            tree.Add(150);
            tree.PrintFromBeginning();
            Console.ReadKey();

        }
    }
}
