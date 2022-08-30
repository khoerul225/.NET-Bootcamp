using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PartThree
{
    internal class Angkot  : Kendaraan
    {
        private decimal hargaTiket;
        private int totalPenumpang;

        public Angkot (int noPolisi, int tahun,  decimal basicReveuner,
                         decimal hargaTiket, int totalPenumpang) : base(noPolisi, tahun, basicReveuner)
        {
            this.HargaTiket = hargaTiket;
            this.TotalPenumpang = totalPenumpang;
            Type = "Angkot ";
            TotalReveuner = basicReveuner + hargaTiket+totalPenumpang;
        }

        public decimal HargaTiket { get => hargaTiket; set => hargaTiket = value; }
        public decimal TotalPenumpang { get => totalPenumpang; set => totalPenumpang = value; }

        public override bool Equals(object obj) => obj is Angkot angkot &&
                   hargaTiket == angkot.hargaTiket;

        public override string? ToString()
        {
            return $"{base.ToString()}| T.HargaTiket = {this.hargaTiket.ToString("C", new CultureInfo("Id-ID"))}" +
                $"| T.TotalPenumpang = {this.totalPenumpang.ToString()}" +
                $"| Total Reveuner : {TotalReveuner.ToString("C", new CultureInfo("Id-ID"))}\n";
        } 
    }
}
