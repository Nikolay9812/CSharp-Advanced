﻿using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            string[,] arr = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    arr[row, col] = currentRow[col];
                }
            }

            string commands;

            while ((commands = Console.ReadLine()) != "END")
            {
                string[] tokens = commands
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


                if (tokens[0] == "swap" && tokens.Length == 5)
                {

                    int firstRow = int.Parse(tokens[1]);
                    int firstCol = int.Parse(tokens[2]);
                    int secondRow = int.Parse(tokens[3]);
                    int secondCol = int.Parse(tokens[4]);

                    if (firstRow >= 0 && firstRow <= rows - 1 && firstCol >= 0 && firstCol <= cols - 1
                        && secondRow >= 0 && secondRow <= rows - 1 && secondCol >= 0 && secondCol <= cols - 1)
                    {

                        string temp = arr[firstRow, firstCol];
                        arr[firstRow, firstCol] = arr[secondRow, secondCol];
                        arr[secondRow, secondCol] = temp;

                        for (int row = 0; row < arr.GetLength(0); row++)
                        {
                            for (int col = 0; col < arr.GetLength(1); col++)
                            {
                                Console.Write($"{arr[row, col]} ");
                            }
                            Console.WriteLine();

                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }

                else
                {
                    Console.WriteLine($"Invalid input!");
                }
            }
        }

    }
}
