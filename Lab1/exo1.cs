using System;

namespace Lab1
{
    public class exo1
    {
        public void multiplication()
        {
            Console.Write("[Exercice 1.1 ]\n");
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                {
                    Console.Write(a + "*" + b + " = " + a * b + "\n");
                }
                Console.Write("\n");
            }
            Console.Write("--------------------------------\n");
        }
        public void multiplication_odd()
        {
            Console.Write("[Exercice 1.2 ]\n");
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                {
                    if ((a * b) % 2 == 1)
                    {
                        Console.Write(a + "*" + b + " = " + a * b + "\n");
                    }
                }
                Console.Write("\n");
            }
            Console.Write("--------------------------------\n");
        }

        public void multiplication_table()
        {
            Console.Write("[Exercice 1.3 ]\n");
            Console.Write("Which multiplication table do you want to display ? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int table = n;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(table + "*" + i + " = " + table * i + "\n");
            }
            Console.Write("--------------------------------\n");
        }
    }
}