using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public class m
    {
        //No 1
        public static void displayHashset(HashSet<int> number1)
        {

            foreach (int tampil in number1)
            {
                Console.Write($" {tampil}");
            }
        }
        public static void Reverse(HashSet<int> number1)
        {

            foreach (int tampil in number1)
            {
                Console.Write($" {tampil}");
            }
        }
        public static void SameElement(HashSet<int> number1, HashSet<int> number2)
        {
            HashSet<int> result = new HashSet<int>(number1);
            result.IntersectWith(number2);
            Console.WriteLine("Elemen yang sama adalah : ");
            displayHashset(result);
        }

        public static void UnionElement(HashSet<int> number1, HashSet<int> number2)
        {
            HashSet<int> result = new HashSet<int>(number1);
            result.UnionWith(number2);
            Console.WriteLine("Tampilan union : ");
            displayHashset(result);
        }

        public static void ExceptElement(HashSet<int> number1, HashSet<int> number2)
        {
            HashSet<int> result = new HashSet<int>(number1);
            result.ExceptWith(number2);
            Console.WriteLine("Tampilan yang tidak sama : ");
            displayHashset(result);
        }

        public static void SymmetricExceptElement(HashSet<int> number1, HashSet<int> number2)
        {
            HashSet<int> result = new HashSet<int>(number1);
            result.SymmetricExceptWith(number2);
            Console.WriteLine("Tampilan element yang tidak sama A & B : ");
            displayHashset(result);
        }

        static void Main(string[] args)
        {
            HashSet<int> hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            HashSet<int> hs2 = new HashSet<int>() { 1, 2, 3, 4 };

            displayHashset(hs1);
            Console.WriteLine();
            displayHashset(hs2);
            Console.WriteLine();
            SameElement(hs1, hs2);
            displayHashset(hs1);
            Console.WriteLine();
            UnionElement(hs1, hs2);
            Console.WriteLine();
            ExceptElement(hs1, hs2);
            Console.WriteLine();
            Console.WriteLine("Kebalikan angka 1");
            Reverse(hs1);
            Console.WriteLine();
            
            SymmetricExceptElement(hs1, hs2);
        }

        //No. 2


    }
}