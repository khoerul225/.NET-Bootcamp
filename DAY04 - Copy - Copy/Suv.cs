using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PartThree
{
    internal class Suv  : Kendaraan
    {
        private decimal sewa;
        private decimal sopir;

        public Suv (int noPolisi, int tahun,decimal totalReveuner,
                         decimal sewa,decimal sopir) : base(noPolisi, tahun,basicReveuner)
        {
            this.Sewa = sewa;
            this.Sopir = sopir;
            Type = "Suv ";
            totalReveuner = basicReveuner + sewa + sopir;
        }

        public decimal Sewa { get => sewa; set => sewa = value; }
        public decimal Sopir { get => sopir; set => sopir = value; }


        public override string? ToString()
        {
           return $"{base.ToString()}| T.Sewa = {this.sewa.ToString("C", new CultureInfo("Id-ID"))}" +
                $"| T.Sopir = {this.sopir.ToString("C", new CultureInfo("Id-ID"))}" +
                $"| Total Reveuner : {TotalReveuner.ToString("C", new CultureInfo("Id-ID"))}\n";
         } 
    }
}
