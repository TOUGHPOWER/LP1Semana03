using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            int col, row;
            float[,] biArray ;
            float[] rowAverages ;
            float rowElementsSum = 0;
            float totalAverageSum = 0;
            
            Console.Write("Please input number of rows:");
            row = int.Parse(Console.ReadLine());
            Console.Write("Please input number of columns:");
            col = int.Parse(Console.ReadLine()); 
            biArray = new float [row , col];
            rowAverages = new float[row];

            for(int i = 0; i < biArray.GetLength(0);i++)
            {
                
                
                for(int j = 0; j < biArray.GetLength(1);j++)
                {
                    float inputNumber = float.Parse(Console.ReadLine());
                    biArray[i,j] = inputNumber;
                    //sum of the row elements
                    rowElementsSum += biArray[i,j];
                    
                    
                    
                }
                
                float rowAverage = rowElementsSum/col;
                Console.WriteLine($"The average is: {rowAverage}");
                rowAverages[i] = rowAverage;
                //Variable Reset
                rowAverage = 0;
                rowElementsSum = 0;
                
                totalAverageSum += rowAverages[i];
                
            }
            Console.WriteLine($"The total of the averages is: {totalAverageSum}");


            
        }
    }
}
