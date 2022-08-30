using System;
using static System.Console;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartThree
{
    internal class Kendaraan
    {
        //instant variable = sudah di create objeknya
        private int noPolisi;
        private int tahun;
        private Decimal basicReveuner;
         private string type;
        private decimal totalReveuner;


        //static variable
        public static decimal totalBasic = 0M;
        public static int totalKendaraan = 0;
        public Kendaraan()
        {
            totalKendaraan++;
            totalBasic += this.basicReveuner;
            this.TotalReveuner = this.basicReveuner;
        }

        //constructor parameter
        public Kendaraan(int noPolisi, int tahun, string type, decimal basicReveuner)
        {
            this.noPolisi = noPolisi; // pake random // new Random
            this.tahun = tahun;
            this.type = type;
            this.basicReveuner = basicReveuner;
            totalKendaraan++;
            totalBasic += this.basicReveuner;
            this.TotalReveuner = this.basicReveuner;
        }

        public Kendaraan(int noPolisi, int tahun, string type, decimal basicReveuner ) : this(noPolisi, tahun, type, basicReveuner)
        {
            this.type = type;
        }


        public override string? ToString()
        {
            return $"Kendaraan = {this.noPolisi}|Nama : {this.tahun}| type : {this.type}| Basic Salary : {this.basicReveuner.ToString("C", new CultureInfo("Id-ID"))}\n";
            Console.WriteLine();
        }

        private decimal GetTotalReveuner()
        {
            return this.basicReveuner
;
        }

        //GetSet / Getter Setter
        public int noPolisi { get => noPolisi; set => noPolisi = value; }
        public int tahun { get => tahun; set => tahun = value; }
        public string LastName1 { get => type; set => type = value; }
        public decimal BasicReveuner

        {
            get => BasicReveuner;
            set
            {
                basicReveuner = value;
                totalReveuner = basicReveuner;
            }

        }

        public static void No1()
        {
            Suv  suv1 = new Suv (120, 2015, "SUV",  500_000,100_000,600_000);
            Suv  suv2 = new Suv (120, 2019, "SUV",  500_000,100_000,600_000);
 
            WriteLine("===================================================List Suv ===============================================================");

            //store to list (mempermudah menampilkan menggunakan list)
            List<Kendaraan> listKendaraans = new List<Kendaraan> { suv1,suv2 };

            foreach (var item in listKendaraans)
            {
                WriteLine(item.ToString());
            }

            WriteLine();
            WriteLine("================================================================================================================================");
            WriteLine($"Total employee : {Kendaraan.totalKendaraan}");
            WriteLine($"total Basic Salary : {Kendaraan.totalBasic.ToString("C", new CultureInfo("Id-ID"))}");
            WriteLine("================================================================================================================================");
            Console.WriteLine("Press any key to .............");
            Console.ReadLine();
        }
        public static void No2()
        {
            Taxi  taxi12 = new Taxi (123, 2018, "TAXI",5,4_500,40,10_000, 230_000);
            Taxi  taxi13 = new Taxi (125, 2018, "TAXI",10,4_500,100,10_000,  550_000);
            //store to list (mempermudah menampilkan menggunakan list)
            List<Kendaraan> listKendaraans = new List<Kendaraan> { taxi12,taxi13 };
            WriteLine("=======================================================List Taxi ===============================================================");
            foreach (var item in listKendaraans)
            {
                WriteLine(item.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to .............");
        }
        public static void No3()
        {

            Angkot angkot14 = new Angkot(124,2010, "Angkot",4_500,35,  6_000_000);
            Angkot angkot15 = new Angkot(126,2010, "Angkot",4_500,40,  6_000_000);
            //store to list (mempermudah menampilkan menggunakan list)
            List<Kendaraan> listKendaraans = new List<Kendaraan> {angkot14,angkot15};
            WriteLine("===================================================List Quality A==============================================================");
            foreach (var item in listKendaraans)
            {
                WriteLine(item.ToString());
            }

            WriteLine();
            WriteLine("================================================================================================================================");
            WriteLine($"Total employee : {Kendaraan.totalKendaraan}");
            WriteLine($"total Basic Salary : {Kendaraan.totalBasic.ToString("C", new CultureInfo("Id-ID"))}");
            WriteLine("================================================================================================================================");
            Console.WriteLine("Press any key to .............");
            ReadLine();

        }

        public static void No4()
        {
            Suv  suv1 = new Suv (120, 2015, "SUV",  500_000,100_000,600_000);
            Suv  suv2 = new Suv (120, 2019, "SUV",  500_000,100_000,600_000);

            Taxi  taxi12 = new Taxi (123, 2018, "TAXI",5,4_500,40,10_000, 230_000);
            Taxi  taxi13 = new Taxi (125, 2018, "TAXI",10,4_500,100,10_000,  550_000);

            Angkot angkot14 = new Angkot(124,2010, "Angkot",4_500,35,  6_000_000);
            Angkot angkot15 = new Angkot(126,2010, "Angkot",4_500,40,  6_000_000);
            //store to list (mempermudah menampilkan menggunakan list)
            List<Kendaraan> listKendaraans = new List<Kendaraan> { prog9, prog10, prog11,sales12,sales13,qa14,qa15 };

            WriteLine("===================================================SEMUA LIST EMPLOYE=========================================================");
            foreach (var item in listKendaraans)
            {
                WriteLine(item.ToString());
            }

            WriteLine();
            WriteLine("================================================================================================================================");
            WriteLine($"Total employee : {Kendaraan.totalKendaraan}");
            WriteLine($"total Basic Salary : {Kendaraan.totalBasic.ToString("C", new CultureInfo("Id-ID"))}");
            WriteLine("================================================================================================================================");
            Console.WriteLine("Press any key to .............");
            ReadLine();

        }
        public string Type { get => type; set => type = value; }
        public decimal TotalReveuner { get => totalReveuner; set => totalReveuner = value; }

        //overloading constructor = menambah object


    }
}
