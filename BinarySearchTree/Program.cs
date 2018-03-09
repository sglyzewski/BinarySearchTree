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
            tree.Add(27);
            tree.Add(150);
            tree.Add(28);
            tree.Add(160);
            tree.Add(110);
            tree.Add(109);
            tree.Add(26);
            tree.Search(109);
            tree.Search(26);
            tree.Search(5);
            Console.ReadKey();

        }
    }
}
