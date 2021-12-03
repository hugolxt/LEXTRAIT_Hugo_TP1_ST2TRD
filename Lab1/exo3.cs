using System;
namespace Lab1
{
    public class exo3
    {
        private static int PowerFunction(int x) // Function that allow to process the calculation
        {
            int output = (10/(int)(Math.Pow(x, 2) - 4));
            Console.WriteLine("Result of calculation is : " + output);
            return output;
        }
        public class Wrong_Argument : Exception
        {
            public Wrong_Argument(string message): base(message)
            { }
        }

        public void try_catch()
        {
            Console.Write("Please enter a number between -3 and 3 (except -2 and 2 which are causing a DividedByZeroException : ");
            String input = Console.ReadLine();
            try
            {
                int isNumeric;
                bool isNumber = int.TryParse(input, out isNumeric); // is input an integer ?  isNumeric is the output

                if (((Convert.ToInt32(isNumeric)) < -3) || (3 < (Convert.ToInt32(isNumeric))) || (isNumber == false))
                {
                    throw new Wrong_Argument(String.Format(""));
                }
                PowerFunction(isNumeric);
            }
            catch (Exception e) 
            {
                Console.WriteLine("Error exception catched : "+e);
                exo3 obj = new exo3();
                obj.try_catch();
            }    

        }
    }
}