using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            LinkListOperation listOperation = new LinkListOperation();
            listOperation.append(56);
            listOperation.append(30);
            listOperation.append(70);
            listOperation.display();
            Console.ReadLine();
        }
    }
}
