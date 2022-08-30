using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP
{
    internal class Transportation
    {
        //// Membuat intnt variable
        ///// membuat konstruktor
        ///// Membuat Override / Return (ctrl + .(dot))
        ///// membuat get set (HAnya centang srting)


        ///Instan Variable
        ///        private int empId;
       
        private string noPolisi;
        private int tahun;
        private string type;
        private decimal totalRevenue;

        public Transportation(string noPolisi, int tahun, string type, decimal totalRevenue)
        {
            this.noPolisi = noPolisi;
            this.tahun = tahun;
            this.type = type;
            this.totalRevenue = totalRevenue;
        }
        public Transportation()
        {
            totalRevenue++;
        }


        public override string? ToString()
        {
            return $"Transportation={this.noPolisi} |Tahun = {this.tahun}| Type {this.type} |Total : {this.totalRevenue}";
        }



        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public string Type { get => type; set => type = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }





    }
}
