using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class Matrix
    {
        public static void InitMatrix()
        {
            int[,] matrix = new int[5, 5];
            matrix[2, 2] = 125;
             Console.WriteLine(matrix);
        }
/*
        public static int[,] FillRandomMatrix(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++) // i = baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++)// j= kolom
                {
                    matrix[i, j] = random.Next(20);
                }
            }

            return matrix;
        }


        public static int[,] MatrixDiagonal(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = 0;

            // fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // isi diagonal
                    if (i == j)
                    {
                        matrix[i, j] = counter++;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 10;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            return matrix;
        }

        public static void DisplayMatrixChar(char[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write($"Student{i}\t");
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static void no15 ()
         {
            char[,] mat =  
                    {
                    {'A','B','A','C','C','D','E','E','A','D'},
                    {'D','B','A','B','C','A','E','E','A','D'},
                    {'E','D','D','A','C','B','E','E','A','D'},
                    {'C','B','A','E','D','C','E','E','A','D'},
                    {'A','B','D','C','C','D','E','E','A','D'},
                    {'B','B','E','C','C','D','E','E','A','D'},
                    {'B','B','A','C','C','D','E','E','A','D'},
                    {'E','B','E','C','C','D','E','E','A','D'},
                    };


            char[] kunci = { 'D', 'B', 'D', 'C', 'C', 'D', 'A', 'E', 'A', 'D' };
            int count = 0;


            

        }


        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // looping baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//loop kolom
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void DisplayMatrix(char [,] matrix)
        {
            char[] jawaban = new char[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            { 

            }

            for (int i = 0; i < matrix.GetLength(0); i++) // looping baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//loop kolom
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
*/
    }
}