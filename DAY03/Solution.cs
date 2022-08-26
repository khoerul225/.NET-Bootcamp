namespace Quiz03
{
    class Solution
    {
        public static void DisplayMatrix(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    Console.Write($"{mat[i, j]}\t");
                }
                Console.WriteLine();
            }
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
        public static void Soal1()
        {
            int[,] mat = new int[5, 5];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        mat[i, j] = i + 1;
                    }
                    else if (j > i)
                    {
                        mat[i, j] = 10;
                    }
                    else
                    {
                        mat[i, j] = 20;
                    }
                }
            }
            DisplayMatrix(mat);
            Console.WriteLine("-------------------");
        }
        public static void Soal9()
        {
            int[,] mat = new int[5, 5];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        mat[i, j] = mat.GetLength(1) - j;
                    }
                    else if (j < i)
                    {
                        mat[i, j] = 10;
                    }
                    else
                    {
                        mat[i, j] = 20;
                    }
                }
            }
            Console.WriteLine("--------Jawaban Nomor 9-----------");
            Console.WriteLine("----------------------------------");
            DisplayMatrix(mat);
            Console.WriteLine("----------------------------------");
        }
        public static void Soal10()
        {
            int[,] mat = new int[5, 5];
            Random r = new Random();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = r.Next(0, 101);
                }
            }
            DisplayMatrix(mat);
            int diagonalSum = 0;
            Console.WriteLine("--------Jawaban Nomor 10-----------");
            Console.WriteLine("----------------------------------");
            Console.Write($"Diagonal: ");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == j || i == mat.GetLength(1) - j - 1)
                    {
                        Console.Write($"{mat[i, j]}; ");
                        diagonalSum += mat[i, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Diagonal Sum Value {diagonalSum}");
            Console.WriteLine("----------------------------------");
        }
        public static void Soal11()
        {
            Console.Write("Masukan Panjang Matrix: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mat = new int[n, n];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == 0 || i == mat.GetLength(0) - 1)
                    {
                        mat[i, j] = i + j;
                        Console.Write($"{mat[i, j]}\t");
                    }
                    else if (j == 0 || j == mat.GetLength(1) - 1)
                    {
                        mat[i, j] = i + j;
                        Console.Write($"{mat[i, j]}\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------");
        }
        public static void Soal12()
        {
            Console.Write("Masukan Panjang Matrix: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mat = new int[n + 1, n + 1];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == mat.GetLength(0) - 1)
                    {
                        int sum = 0;
                        for (int x = 0; x < i; x++)
                        {
                            sum += mat[x, j];

                        }
                        mat[i, j] = sum;
                    }
                    else if (j == mat.GetLength(0) - 1)
                    {
                        int sum = 0;
                        for (int x = 0; x < j; x++)
                        {
                            sum += mat[i, x];

                        }
                        mat[i, j] = sum;
                    }
                    else
                    {
                        mat[i, j] = i + j;
                    }
                }
            }
            mat[n, n] = mat[n, n / 2];
            DisplayMatrix(mat);
            Console.WriteLine("-------------------");
        }
        public static void Soal13()
        {
            Console.Write("Masukan Panjang Matrix: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //diagonal, semakin ke kanan semakin besar
                    if (j == n - i - 1)
                    {
                        mat[i, j] = j;
                    }
                    //kanan, semakin ke bawah semakin besar
                    else if (j == n - 1)
                    {
                        mat[i, j] = i + j;
                    }
                    //bawah, semakin ke kiri semakin besar
                    else if (i == n - 1)
                    {
                        //keliling segitiga - j
                        mat[i, j] = ((n - 1) * 3) - (j);
                    }
                    else
                    {
                        mat[i, j] = 0;
                    }
                }
            }
            /*Console.WriteLine("Matrix Awal:");
            DisplayMatrix(mat);*/
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //area dibawah diagonal
                    if (j >= n - i - 1)
                    {
                        //setiap isi matrix kelipatan 4 diubah menjadi 3
                        if ((mat[i, j] + 1) % 4 == 0)
                        {
                            mat[i, j] = 3;
                            Console.Write($"{mat[i, j]}\t");
                        }
                        //tengah kosong
                        else if (mat[i, j] == 0 && j != n - i - 1)
                        {
                            Console.Write("\t");
                        }
                        //selain kelipatan 4, dikali 3
                        else
                        {
                            int x = mat[i, j] - (mat[i, j] / 4);
                            mat[i, j] = 2 + (3 * x);
                            Console.Write($"{mat[i, j]}\t");
                        }
                    }
                    //area diatas diagonal kosong
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------");
        }
        public static void Soal14()
        {
            Console.Write("Masukan Panjang Matrix: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == n - 1)
                    {
                        //semakin ke kanan dan bawah, semakin besar
                        mat[i, j] = i + j;
                    }
                    else if (i == n - 1 || j == 0)
                    {
                        //semakin ke kiri atas, semakin besar
                        mat[i, j] = ((n - 1) * 4) - (i + j);
                        //keliling matrix - (i+j)
                    }
                    else
                    {
                        mat[i, j] = 0;
                    }
                }
            }
            /*Console.WriteLine("Matrix Awal:");
            DisplayMatrix(mat);*/
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //setiap isi matrix kelipatan 4 diubah menjadi 3
                    if ((mat[i, j] + 1) % 4 == 0)
                    {
                        mat[i, j] = 3;
                        Console.Write($"{mat[i, j]}\t");
                    }
                    else if (i > 0 && i < n - 1 && j > 0 && j < n - 1)
                    {
                        //tengah kosong
                        Console.Write("\t");
                    }
                    else
                    {
                        //selain kelipatan 4, dikali 3
                        int x = mat[i, j] - (mat[i, j] / 4);
                        mat[i, j] = 2 + (3 * x);
                        Console.Write($"{mat[i, j]}\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------");
        }
        public static void Soal15()
        {
            char[,] ujian = new char[8, 9];
            Random r = new Random();
            for (int i = 0; i < ujian.GetLength(0); i++)
            {
                for (int j = 0; j < ujian.GetLength(1); j++)
                {
                    ujian[i, j] = (char)r.Next('A', 'F');
                }
            }
            DisplayMatrixChar(ujian);
            char[] kunci = new char[9];
            Console.Write("Kunci Jawaban:\t");
            for (int i = 0; i < kunci.Length; i++)
            {
                kunci[i] = (char)r.Next('A', 'F');
                Console.Write($"{kunci[i]}\t");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < ujian.GetLength(0); i++)
            {
                for (int j = 0; j < ujian.GetLength(1); j++)
                {
                    if (ujian[i, j] == kunci[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Jawaban siswa {i} yang benar: {count}");
                count = 0;
            }
        }
    }
}
