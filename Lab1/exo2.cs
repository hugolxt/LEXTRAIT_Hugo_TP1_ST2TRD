using System;
namespace Lab1
{
    public class exo2
    {
        // 2-1  Write a function Prime() that prints all prime number between 1 and 1000.
        //      System.Math.Sqrt() is allowed for this exercise only.
        public void prime(int limit){
            Console.Write("[Exercice 2.1 ]\n");
            for (int n = 1; n < limit; n++)
            {
                bool isPrime = true;
                for (int j = 2; j < n; j++)
                {
                    if(n % j == 0){
                        isPrime = false;
                    }
                }
                if(isPrime ==  true){
                    Console.WriteLine("("+n+") is a prime number");
                    isPrime = false;
                }
            }
            Console.Write("--------------------------------\n");
        }
        
        // 2-2  Write a Fibonacci function F with F(0) = 1, F(1) = 1 and F(N) = F(N-1) + F(N-2) for N >=2.
        //      The number N is determined by asking a value to the user through the console.
        public void fibonacci(){
            Console.Write("[Exercice 2.2 ]\n");
            // Be aware that long are only stored on 64bits 
            Console.Write("Give an interger for the limit of the Fibonnaci function : ");
            long limit = Convert.ToInt32(Console.ReadLine()); 
            long f0 = 1, f1 = 1;  
            Console.Write("f(0) = "+f0+"\n");
            Console.Write("f(1) = "+f1+"\n");  
            for (int i = 2; i < limit; i++)  
            {  
                long fn =  f0 + f1;
                Console.Write("f("+i+") = "+fn+"\n");  
                f0= f1;  
                f1= fn;  
            }
            Console.Write("--------------------------------\n");
        }
        //2.3   Write a factorial function. Reminder:
        //      a. 4! = 4*3*2*1 = 24
        //      b. 6! = 6*5*4*3*2*1 = 720
        //      c. What would happen if you tried to calculate 420.000!?
        //      ANSWER:
        //          If we enter a number that is too large then the nested execution of the recursive algorithm gathers too many function calls.  
        //          Indeed, a recursive function call is equivalent to a call that calls the program again. 
        //          In the example of the number 420 000! then the program returns the following error :
        //          Stack overflow. Repeat 174630 times:
        //      d. Theorical: what is recursive function?
        //      ANSWER :
        //          Recursive function 
        //          As previously introduced a recursive function is a function that call itelfback during it's execution. 
        //          The most important line in a recursiv function is the stop condition that alow the recursiv execution to end the function callback.
        public double factorial(int n){
            if (n == 1) // stop condition if the number = 1 we end up the recursive callback
                return 1;
            else
                return n * factorial(n - 1); // we call back the function with the n-1 unless it stop with the condition before
        }
        
    }
}