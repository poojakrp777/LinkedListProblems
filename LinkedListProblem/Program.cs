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

            LinkListOperation linkistOperation = new LinkListOperation();
            linkistOperation.Add(56);
            linkistOperation.Add(30);
            linkistOperation.Add(70);
            linkistOperation.Display();
            linkistOperation = new LinkListOperation();
            linkistOperation.Add2(70);
            linkistOperation.Add2(30);
            linkistOperation.Add2(56);
            linkistOperation.Display();
            linkistOperation = new LinkListOperation();
            linkistOperation.Add(56);
            linkistOperation.Add(70);
            linkistOperation.Display();
            Console.WriteLine("\n");
            linkistOperation.InsertAtParticularPoistion(2, 30);
            linkistOperation.Display();
            Console.WriteLine("First element is poped out from linked list = " + linkistOperation.removeFirstNode().data);
            linkistOperation.Display();
            linkistOperation.InsertAtParticularPoistion(1, 56);
            linkistOperation.Display();

            Console.WriteLine("Last element is poped out from linked list = " + linkistOperation.removeLastNode().data);
            linkistOperation.Display();
            Console.ReadLine();
        }
    }
}
