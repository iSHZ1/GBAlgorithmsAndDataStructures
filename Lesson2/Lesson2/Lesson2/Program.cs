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

        public Node ProgramInput()
        {
            Console.WriteLine("Если хотите добавить экземпляр в массив? Y/N");
            Char n = Convert.ToChar(Console.ReadKey());


            if (n =='Y' || n == 'y')
            {
                Console.WriteLine("введите значение Нода");
                return new Node();
            }
            if (n == 'N' || n == 'n')
            {
                return;
            }
            else
            {
                Console.WriteLine("Повторите попытку ввода");
            }
        }

    }
}
