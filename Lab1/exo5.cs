using System;
using System.Collections.Generic;

namespace Lab1
{
    public class exo5
    {
        static public int tree(){
            
            Console.Write("Enter the size of the tree : ");
            int size;
            int.TryParse(Console.ReadLine(), out size);
            if (size > 20 || size < 1 )
            {
                Console.WriteLine("Your input is incorect. Enter a number between {1,2,3,...,20} retry...");
                tree();
                return 0;
            }
            
            Console.WriteLine("\nTree size "+ size+" :\n");
            int leaves = 1;
            int spaces = size-1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < spaces; j++){
                    Console.Write(" ");
                }
                for (int j = 0; j < leaves; j++){
                    Console.Write("*");
                }
                Console.Write("\n");
                leaves = leaves + 2;
                spaces = spaces - 1;
            }
            for (int j = 0; j < (size-2); j++){
                Console.Write(" ");
            }
            Console.Write("|");
            Console.Write(" ");
            Console.Write("|\n\n");
            return size;
        }
        
        static public void decorateTree(int size){
            
            Console.Write("Hey buddy do you want to decorate your tree ? {y,n}");
            char answer;
            char.TryParse(Console.ReadLine(), out answer);
            if ('y'.CompareTo(answer) != 0 && 'n'.CompareTo(answer) != 0 )
            {
                Console.WriteLine("Your input is incorrect. Retry...");
                decorateTree(size);
                return ;
            }
            
            //------------------------------------
            int leaves = 1;
            int spaces = size-1;
            int decoration = 1;
            int temp = 0;
            var decorations = new List<int>();
            //------------------------------------
            if ('n'.CompareTo(answer) == 0)
            {
                Console.WriteLine("OK sir your tree wil stay undecorated forever :(");
            }
            else
            { 
                Console.WriteLine("\nTree size "+ size+" :\n");
                for (int i = 0; i < size; i++) // lines of the tree
                {
                    temp = decoration;
                    decorations.Add(decoration);
                    
                    //create the array with the decorations positions
                    if(i == 0){
                        decorations.Clear();
                        if(i == 0){
                            decorations.Add(-1); 
                        }
                        if(i == 1){
                            decorations.Add(10); 
                        }
                    }else{
                        while (temp > 1)
                        {
                            if ((temp - 3) >= 1){
                                temp = temp - 3;
                                decorations.Add(temp);
                            }else{
                                temp = temp - 2;
                            }
                        }
                        decoration = decoration + 2;
                    }     
                    //  Allow us to display the list that we formed in order to decore our tree
                    //decorations.ForEach(Console.WriteLine);

                    for (int j = 0; j < spaces; j++){
                        Console.Write(" ");
                    }
                    for (int j = 0; j < leaves; j++){  
                        if((j+1) == decorations[decorations.Count - 1]){
                            
                            if(j % 4 == 0){
                                Console.Write("i");
                            }else{
                                Console.Write("o");
                            }

                            if(decorations.Count > 1){
                                decorations.RemoveAt(decorations.Count - 1);
                            }
                        }
                        else {
                            Console.Write("*");
                        }
                    }
                    
                    Console.Write("\n");
                    //  Adjust our leaves and spaces according to the tree's form
                    leaves = leaves + 2;
                    spaces = spaces - 1;
                    decorations.Clear();
                }
                
                for (int j = 0; j < (size-2); j++){
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write(" ");
                Console.Write("|\n\n");                
             
            }
            
        }
    }
}