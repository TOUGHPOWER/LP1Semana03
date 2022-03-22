using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            int col, row;
            float[,] biArray ;
            
            Console.Write("Please input number of columns:");
            col = int.Parse(Console.ReadLine());
            Console.Write("Please input number of rows:");
            row = int.Parse(Console.ReadLine()); 
            biArray = new float [col , row];
            
            for(int i = 0; i < biArray.GetLength(0);i++)
            {
                for(int j = 0; j < biArray.GetLength(0);j++)
                {
                    float inputNumber = float.Parse(Console.ReadLine());
                    
                }
                
            }
            


            
        }
    }
}
