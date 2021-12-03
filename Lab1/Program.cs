using System;
namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             *  Author : Hugo Lextrait Promo 2022
             *  Student number : 20170687
             *  Email Adress : hugo.lextrait.20170687@efrei.net
             *  Date : 3 december 2021
             *
             *  infos : You will find the answers of the questions directly commented in the files exoN.cs
             *          exemple : 2.3.c What would happen if you tried to calculate 420.000!?
             */
            
            Console.Write("***********************************************\n");
            Console.Write("[ EXERCICE 1 ]\n");
            exo1 exo1 = new exo1();
            // 1.1 Print every multiplication table from 1*1 to 10*10.
            exo1.multiplication();

            // 1.2 Print only the odd result (i.e.: 3*7 = 21). Tip: use the modulo (%) operator.
            
            exo1.multiplication_odd();

            // 1.3 Print only the odd result (i.e.: 3*7 = 21). Tip: use the modulo (%) operator.
            exo1.multiplication_table();;
            
            
            Console.Write("***********************************************\n");
            Console.Write("[ EXERCICE 2 ]\n");
            exo2 exo2 = new exo2();
            
            //  2.1 - Prime function 
            exo2.prime(1000);
            //  2.2 - Fibonacci function 
            exo2.fibonacci();
            //  2.3 - Factorial function 
            // 2.3.a - 4! 
            Console.WriteLine("Factorial of 4 is "+exo2.factorial(4));
            //  2.3.b - 6! 
            Console.WriteLine("Factorial of 6 is "+exo2.factorial(6));
            //  2.3.c - 420000! 
            Console.Write("Enter a number to factorial it : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of "+n+" is "+exo2.factorial(n));
            
            
            Console.Write("***********************************************\n");
            Console.Write("[ EXERCICE 3 ]\n");
            exo3 exo3 = new exo3();
            exo3.try_catch();
            
            Console.Write("***********************************************\n");
            Console.Write("[ EXERCICE 4 ]\n");
            exo4 exo4 = new exo4();
            exo4.rectangle();

            Console.Write("***********************************************\n");
            Console.Write("[ EXERCICE 5 ]\n");
            exo5 exo5 = new exo5();
            
            int treeSize = exo5.tree();
            exo5.decorateTree(treeSize);
            



        }
    }
}