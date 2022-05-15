﻿using System;
namespace Lesson2
{
    public interface ILinkedList
    {
        int GetCount(Node StartNode)
        {
            int SearchIndex = 1;

            Node FNode = StartNode;
            while (FNode.NextNode != null)
            {
                FNode = FNode.NextNode;
                SearchIndex++;
            }
            return SearchIndex;
        }


        void AddNode(Node StartNode, int value)
        {

            Node NewNode = new Node(value);
            NewNode.NextNode = StartNode;
            Node PrevNode = null;

            while (NewNode.NextNode != null)
            {
                PrevNode = NewNode;
                NewNode = NewNode.NextNode;
            }

            StartNode.NextNode = NewNode;
            NewNode.NextNode = null;
            NewNode.PrevNode = PrevNode;
        }


        void AddNodeAfter(Node node, int value)
        {
            Node NewNode = new Node(value);
            NewNode.NextNode = node.NextNode;
            NewNode.PrevNode = node;
            NewNode.NextNode.PrevNode = NewNode;
            node.NextNode = NewNode;
        }

        void RemoveNode(Node node)
        {
            node.PrevNode.NextNode = node.NextNode;
            node.NextNode.PrevNode = node.PrevNode;
            node.NextNode = null;
            node.PrevNode = null;
        }

        void RemoveNode(Node startNode, int index)
        {
            if (index == 0)
            {
                startNode.NextNode.PrevNode = null;
                startNode = startNode.NextNode;
                return;
            }

            int currentIndex = 0;
            Node currentNode = startNode;

            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    RemoveNode(currentNode);
                    return;
                }

                currentNode = currentNode.NextNode;
                currentIndex++;
            }
        }

        // удаляет указанный элемент
        Node FindNode(Node StartNode, int searchValue)
        {
            Node SearchNode = StartNode;

            while (SearchNode.NextNode != null)
            {
                if (searchValue == SearchNode.Value)
                    return SearchNode;
                SearchNode = SearchNode.NextNode;
            }

            return null;
        }
        // ищет элемент по его значению
    }
}