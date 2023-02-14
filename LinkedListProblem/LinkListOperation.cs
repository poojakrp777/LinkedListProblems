﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class LinkListOperation
    {
        public Node head;

        public void insert(int value)
        {
            Node newNode = new Node();
            newNode.data = value;
            newNode.next = null;
            if (head != null)
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            else
            {
                head = newNode;
            }
        }
        public void Add(int value)
        {
            Node newNode = new Node();
            newNode.data = value;
            newNode.next = null;
            Node temp = head;
            head = newNode;
            newNode.next = temp;
        }
        public void display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            else
            {
                Node temp = head;

                while (temp.next != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
                Console.WriteLine(temp.data);
            }
        }
    }
}
