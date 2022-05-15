﻿using System;
namespace Lesson2
{
    public class Node : ILinkedList
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }

        public Node(int value)
        {
            Value = value;
        }

        public Node() { }

        public int GetCount()
        {
            int SearchIndex = 1;
            Node FNode = NextNode;

            while (NextNode != null)
            {
                FNode = NextNode;
                SearchIndex++;
            }

            FNode = null;
            return SearchIndex;
        }
    }
}
