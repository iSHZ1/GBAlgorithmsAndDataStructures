using System;
using System.Collections.Generic;

namespace Lesson2
{
    class Program
    {
        static void Main()
        {

            List<Node> ArrayNode = new List<Node>();
            bool ProgramStart = true;

            while(ProgramStart)
            {

                ArrayNode.Add(ProgramInput());
                if (true)
                {

                }
            }

        }

        public static Node ProgramInput()
        {
            Console.WriteLine("Введите значение экземпляра");
            int Input = Convert.ToInt32(Console.ReadLine());
            return new Node(Input);
        }

    }
}
