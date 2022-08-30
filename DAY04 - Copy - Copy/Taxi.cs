using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PartThree
{
    internal class Taxi  : Kendaraan
    {
        private int order;
        private decimal orderPerKm;
        private int totalKm;
        private decimal bonus;
        /*private decimal transportasi;*/

        public Taxi (int noPolisi, int tahun, decimal basicReveuner, 
                         int order,decimal orderPerKm, int totalKm, decimal bonus) : base(noPolisi, tahun, basicReveuner)
        {
            this.Order = order;
            this.OrderPerKm = orderPerKm;
            this.TotalKm = totalKm;
            this.Bonus = bonus;
            Type = "Taxi ";
            TotalReveuner = basicReveuner + order + orderPerKm +bonus;
        }

        public decimal Order { get => order; set => order = value; }
        public decimal OrderPerKm { get => orderPerKm; set => orderPerKm = value; }
        public int TotalKm { get => totalKm; set => totalKm = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }


        public override string? ToString()
        {
            return $"{base.ToString()}| T.Order = {this.order.ToString()}" +
                $"| T.OrderPerKm = {this.orderPerKm.ToString("C", new CultureInfo("Id-ID"))}" +
                $"| T.TotalKm = {this.totalKm.ToString("C", new CultureInfo("Id-ID"))}" +
                $"| T.Bonus = {this.bonus.ToString("C", new CultureInfo("Id-ID"))}" +
                $"| Total Reveuner : {TotalReveuner.ToString("C", new CultureInfo("Id-ID"))}\n";
        }
    }
}
