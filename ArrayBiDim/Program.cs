using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] biArray ;
            int col,row;
            Console.Write("Please input number of columns:");
            col = int.Parse(Console.ReadLine());
            Console.Write("Please input number of rows:");
            row = int.Parse(Console.ReadLine()); 
            biArray = new float [col , row];
            


            
        }
    }
}
