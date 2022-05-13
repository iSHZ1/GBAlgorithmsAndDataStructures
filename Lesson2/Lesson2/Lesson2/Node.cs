using System;
namespace Lesson2
{
    public class Node : ILinkedList
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }

        public Node(int Input)
        {
            Value = Input;
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void AddNode(int value)
        {
            throw new NotImplementedException();
        }

        public void AddNodeAfter(Node node, int value)
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }

        public Node FindNode(int searchValue)
        {
            throw new NotImplementedException();
        }
    }
}
