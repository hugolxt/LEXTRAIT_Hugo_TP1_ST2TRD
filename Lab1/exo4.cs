using System;
namespace Lab1
{
    public class exo4
    {
        public void rectangle()
        {
            int output;
            Console.WriteLine("Please be aware to enter only numeric values.");
            Console.Write("Enter n : ");
            int.TryParse(Console.ReadLine(), out output);
            int n = output;
            Console.Write("Enter m : ");
            int.TryParse(Console.ReadLine(), out output);
            int m = output;
            //------------------------------------
            if (n == 0  || m == 0)
            {
                Console.WriteLine("One of the inputs seems to be incorect. retry...");
                rectangle();
                return;
            }else
            {
                Console.WriteLine("We have the following dimensions :");
                Console.WriteLine("N = "+n);
                Console.WriteLine("M = "+m);

                //------------------------------------
                int count = 0;
                //------------------------------------
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= m; j++)
                    {
                        if((i==1 & j==1)|(i==n & j == m)|(i==n & j==1)){
                            Console.Write("0");
                        }
                        else if ((i==1 & j==m))
                        {
                            Console.WriteLine("0");
                        }
                        if (((i==1 | i == n) & j!=1 & j!= m))
                        {
                            Console.Write("-");
                        }
                        if (((j == 1 | j == m) & i!=1 & i!= n))
                        {
                            if (j==1)
                            {
                                Console.Write("|");
                            }
                            else
                            {
                                Console.WriteLine("|");
                            }
                        }
                        if (i != 1 & j != 1 & i != n & j != m)
                        {
                            if (count == 0)
                            {
                                Console.Write("*");
                                count++;
                            }
                            else if (count == 2)
                            {
                                Console.Write(" ");
                                count = 0;
                            }
                            else
                            {
                                Console.Write(" ");
                                count++;
                            }
                        }
                    }
                }
                
                
                
            }
        }
        
    }
}