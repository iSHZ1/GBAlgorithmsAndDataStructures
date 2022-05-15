using System;
using System.Collections.Generic;

namespace Lesson2
{
    class Program
    {
        static void Main()
        {
            Node FirstNode = new Node();
            FirstNode.NextNode = null;
            FirstNode.PrevNode = null;

            Console.WriteLine(FirstNode.GetCount());
        }

    }
}
