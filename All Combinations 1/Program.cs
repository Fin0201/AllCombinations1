using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1234;

            string xString = x.ToString(); //Converts the integer to a string so each character can be easily displayed seperately.



            for (int i = 0; i < xString.Length; i++) //A series of for loops that increment each character in the string.
            {
                for (int j = 0; j < xString.Length; j++)
                {
                    for (int k = 0; k < xString.Length; k++)
                    {
                        for (int l = 0; l < xString.Length; l++)
                        {
                            if (i != j && i != k && i != l && j != k && j != l && k != l) //Chacks t see if any characters are the same.
                            {
                                Console.WriteLine($"{xString[i]}{xString[j]}{xString[k]}{xString[l]}"); //Outputs the final values.
                            }
                        }
                    }
                }
            }
        }
    }
}