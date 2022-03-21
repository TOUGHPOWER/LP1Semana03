using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a word or phrase");
            string inputString = Console.ReadLine();
            char inputChar = char.Parse(Console.ReadLine());
            foreach( char c  in inputString)
            {
                if(c == inputChar)
                {
                    inputString = inputString.Replace(c,char.Parse(" "));
                }
                
            }
            Console.WriteLine(inputString);
        }
    }
}
