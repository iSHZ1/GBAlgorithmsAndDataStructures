using System;
using System.Collections.Generic;

namespace Lesson2
{
    class Program
    {
        static object Main()
        {
            List<Node> ArrayNode = new List<Node>();

            do
            {
                if (ArrayNode.Count == 0)
                {
                    Console.WriteLine("Введите значение экземпляра");
                    int Input = Convert.ToInt32(Console.ReadLine());
                    ArrayNode.Add(new Node(Input));

                    ArrayNode[0].PrevNode = null;
                    ArrayNode[0].NextNode = null;
                }


            } while (true);
        }



        public static void NodeAdd(ref List<Node> array)
        {
            Console.WriteLine("Введите значение экземпляра");
            int Input = Convert.ToInt32(Console.ReadLine());
            array.Add(new Node(Input));


        }

    }
}
