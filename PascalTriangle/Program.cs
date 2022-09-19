    using System;
using System.Security.Cryptography;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Pascal triangle, enter any number");

                int triangleHeight = int.Parse(Console.ReadLine());

                int[][] triangleArrays = new int[triangleHeight + 1][];

                for(int row = 0; row < triangleHeight; row++)
                {   
                    triangleArrays[row] = new int[row + 1];
                }


                triangleArrays[0][0] = 1;

                for(int row = 0; row < triangleHeight - 1; row++)
                {
                    for (int col = 0; col < triangleArrays[row].Length; col++)
                    {
                        triangleArrays[row + 1][col] = triangleArrays[row + 1][col] + triangleArrays[row][col];
                        triangleArrays[row + 1][col + 1] = triangleArrays[row + 1][col + 1] + triangleArrays[row][col];
                    }
                }

                for (int row = 0; row < triangleHeight; row++)
                {   

                    Console.Write(new String(' ', (triangleHeight - row) * 3));

                    for (int col = 0; col < row; col++)
                    {
                        Console.Write("{0, 6}", triangleArrays[row][col]);
                    }
                        
                    Console.WriteLine();
                }
            }
        }
    }
}
