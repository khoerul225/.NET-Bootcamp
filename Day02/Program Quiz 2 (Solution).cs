﻿using static System.Console;
using Day02;

int[] arr1 = new int[] { 15, 2, 30, 12, 10, 5 };
int[] arr23 = new int[] { 15, 2, 30, 12, 10, 5 };
int[] arr5 = new int[] { 5, 2, 30, 12, 10, 5, 2, 10, 5 };
int[] arr6 = new int[] { 1, 5, 3, 7, 8, 5, 1, };
int[] arr7 = new int[] { 1, 2, 3, 2, 7, 7, 1, 6, 3, 4, 5, 2, 3, 6, 8, 9 };

bool testing = false;
while (!testing)
{
    Console.Write("Masukan No Soal (N0 1-15):");
    int no = Convert.ToInt32(Console.ReadLine());
    switch (no)
    {
        case 1:
            Quiz02.Solution.Soal1(arr1);
            break;
        case 2:
            Quiz02.Solution.Soal2(arr23);
            break;
        case 3:
            Quiz02.Solution.Soal3(arr23);
            break;
        case 4:
            Quiz02.Solution.Soal3(arr23);
            break;
        case 5:
            Quiz02.Solution.Soal5(arr5);
            break;
        case 6:
            Quiz02.Solution.Soal6(arr6);
            break;
        case 7:
            Quiz02.Solution.Soal7(arr7);
            break;
        case 8:
            Quiz02.Solution.Soal8();
            break;
        case 9:
            Quiz02.Solution.Soal9();
            break;
        case 10:
            Quiz02.Solution.Soal10();
            break;
        case 11:
            Quiz02.Solution.Soal11();
            break;
        case 12:
            Quiz02.Solution.Soal12();
            break;
        case 13:
            Quiz02.Solution.Soal13();
            break;
        case 14:
            Quiz02.Solution.Soal14();
            break;
        case 15:
            Quiz02.Solution.Soal15();
            break;

        default:
            Console.WriteLine($"Tidak ada nomor soal {no}");
            break;
    }
option:
    Console.Write("Lanjut?(Ya(y)/Tidak(n)/Mungkin(m))");
    string opt = Console.ReadLine();
    if (opt == "n")
    {
        Console.WriteLine("Terima Kasih");
        testing = true;
    }
    else if (opt == "y")
    {
        Console.Clear();

    }
    else if (opt == "m")
    {
        Console.Clear();
        Console.WriteLine("Jangan Bingung Dong");
        Console.WriteLine();
        goto option;
    }
    else
    {
        Console.Clear();
        goto option;
    }
}

Console.ReadLine();





/*
Console.WriteLine("-----------NO1---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal1(arr1);
Console.WriteLine("-----------------------");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------NO2---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal2(arr23);
Console.WriteLine("-----------------------");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------NO3---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal3(arr23);
Console.WriteLine("-----------------------");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------NO4---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal4(arr23);
Console.WriteLine("-----------------------");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------NO5---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal5(arr5);
Console.WriteLine("-----------------------");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------NO6---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal6(arr6);
Console.WriteLine("-----------------------");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("-----------NO7---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal7(arr7);
Console.WriteLine("-----------------------");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------------------");
Console.WriteLine("-----------NO8---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal8();
Console.ReadLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------------------");
Console.WriteLine("-----------NO9---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal9();
Console.ReadLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------------------");
Console.WriteLine("-----------NO10---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal10();
Console.ReadLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------------------");
Console.WriteLine("-----------NO11---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal11();
Console.ReadLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------------------");
Console.WriteLine("-----------NO12---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal2();
Console.ReadLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------------------");
Console.WriteLine("-----------NO13---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal13();
Console.ReadLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------------------");
Console.WriteLine("-----------NO14---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal13();
Console.ReadLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------------------");
Console.WriteLine("-----------NO15---------");
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal13();
Console.ReadLine();
Console.WriteLine();
Console.WriteLine();
*/






