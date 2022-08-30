using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP
{
    internal class Suv : Transportation
    {
        private decimal sewa;
        private decimal supir;


        public Suv(string noPolisi, int tahun, string type, decimal totalRevenue) : base(noPolisi, tahun, type, totalRevenue)
        {
            this.sewa = sewa;
            this.supir = supir;
            type = "Suv";
            TotalRevenue =  sewa + supir ;

        }

        public Suv(string noPolisi, int tahun, string type, decimal totalRevenue, int v1, int v2) : this(noPolisi, tahun, type, totalRevenue)
        {
        }

        //Encapsulasi


        //Ovveride
        public override string? ToString()
        {
            return $"{base.ToString()}| T.Transportasi = {this.sewa.ToString("C", new CultureInfo("Id-ID"))}| Total Revenue : {TotalRevenue.ToString("C", new CultureInfo("Id-ID"))}\n";

        }
        public decimal Sewa { get => sewa; set => sewa = value; }
        public decimal Supir { get => supir; set => supir = value; }

    }
}
