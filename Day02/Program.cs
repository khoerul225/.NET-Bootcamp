using static System.Console;
using Day02;

// Script Untuk Menjalankan Array
/*
var myArray = Arrays.InitArraysInt(new int[] { 10, 20, 30, 40, 50 });

var boys = Arrays.InitArraysString(new[] { "asep", "budi", "charlie" });

var arrRandom = Arrays.InitRandomArray(10);

Arrays.DisplayArrayInt(myArray);
WriteLine();
Arrays.DisplayArrayString(boys);

WriteLine();
var total = Arrays.SumAllElement(myArray);
Write($"Total :{total}");

WriteLine();
Arrays.DisplayArrayInt(arrRandom);
var largest = Arrays.FindLargestElement(arrRandom);
var indexOfLargest = Arrays.FindIndexLargest(arrRandom);
WriteLine($"Largest : {largest}");
WriteLine($"Index of Largest : {indexOfLargest}");
WriteLine();
Array.Sort(arrRandom);
WriteLine($"Found at index : {Array.BinarySearch(arrRandom, 25)}");
Arrays.DisplayArrayInt(arrRandom);
Array.Reverse(arrRandom);
WriteLine();

ReadLine();
*/

// Script Untuk Menjalankan Array

/// <summary>
/// int[] arr1234 = new int[] { 15, 2, 30, 12, 10, 5 };
int[] arr5 = new int[] { 5, 2, 30, 12, 10, 5, 2, 10, 5, 30, 45 };
int[] arr6 = new int[] { 1, 5, 3, 7, 8, 5, 1, 9, 9 };
int[] arr7 = new int[] { 1, 5, 3, 7, 8, 5, 1, 9, 9 };
//Jawaban N0 1
int[] n = { 15, 10, 20, 30, 45, 24 };
Console.WriteLine("Before Random Position");
Quiz02.Solution.ReadInt(n);
Console.WriteLine("After Random Position");
var randomArr = Quiz02.Solution.RandomPosition(n);
Quiz02.Solution.ReadInt(n);

Console.WriteLine("-----------------------");
Quiz02.Solution.Soal2(arr1234);
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal3(arr1234);
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal4(arr1234);
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal5(arr5);
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal6(arr6);
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal7(arr7);
Console.WriteLine("-----------------------");
Quiz02.Solution.Soal8();
Console.ReadLine();
/// </summary>
