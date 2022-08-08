using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,,] threeDimArray = new int[2, 3, 2]
            {
                { {2, 3}, {4, 4}, {5, 5},},
                { {6, 6},  {6, 6},  {6, 6} }

            };
            for (int i = 0; i < threeDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < threeDimArray.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDimArray.GetLength(2); k++)
                    {
                        if (threeDimArray[i, j, k] == 10)
                        {
                            Console.WriteLine("Found");
                        }
                        else
                        {
                            Console.WriteLine("Not Found");
                        }
                        Console.WriteLine(threeDimArray[i, j, k]);
                    }
                }
            }

            int[][] jag = new int[3][]
            {
                new int[] { 6, 5, 8, 9, 0 },
                new int[] {6, 9},
                new int[] { 2, 3, 4, 5, 6, 5, 6}
            };
            
            for (int i = 0; i < jag[i].Length; i++)
            {
                for (int j = 0; j < jag[i].Length; j++)
                {
                    Console.WriteLine(jag[i][j]);
                }
            }

            int[][,] jagger = new int[3][,]
            {
                new int[,] { {1, 2}, {2, 3}, {3, 4}, },
                new int[,] { {1, 2}, {2, 3}, {3, 4}, },
                new int[,] { {1, 2}, {2, 3}, {3, 4}, }

            };
            
            for (int i = 0; i < jagger[i].GetLength(0); i++)
            {
                for (int j = 0; j < jagger[j].GetLength(1); j++)
                {
                    for (int k = 0; k < jagger[j].GetLength(2); k++)
                    {
                        Console.WriteLine(jagger[i][j, k]);
                    }
                }
            }


        }
    }
}

