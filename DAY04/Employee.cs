using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY04.partOne
{
    internal class Employee ///Class
    {
       /// Instant Variabel hanya di uba lewat method
       private int empId; //Atribut atau objek
       private string firstName;
       private string lastName;
       private DateTime joinDate;
       private decimal basicSalary;
       private string country;  
       public string Role;
       public static int totalEmploye = 0;
       public static decimal totalSalary = 0M;
        /// Instant Variabel hanya di uba lewat method



        //empty / default construktor di buat default dengan klik kanan lalu konstruktor
        public Employee()
        {
            totalEmploye++;
            totalSalary += this.basicSalary;
        }

        //construktor parametr
        public Employee(int empId, string firstName, string lastName, DateTime joinDate, string country)
        {
            this.empId = empId; ///this mengacu pada arameter default empID mengacu pada parameter fungs
            this.firstName = firstName;
            this.lastName = lastName;
            this.joinDate = joinDate;
            this.country = country;
            totalSalary += this.basicSalary;
        }

        //overload construktor
        public Employee(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string country)
        {
            this.empId = empId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            this.country = country;
            totalEmploye++;
            totalSalary += this.basicSalary;
        }
        public Employee(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string country, string role) : this(empId, firstName, lastName, joinDate, basicSalary, country)
        {
            Role = role;
        }

        public override string? ToString()
        {
            return $"Employee={this.empId} | {this.firstName} {this.lastName} \t | Roles : {this.Role}";

        }


        /// Getter setter dilakukan dengan melakukan blok pada intsan variabel / encapsulasi fill still
        /// get mengambil konstruksi  set  = value manulasi
        public int EmpId { get => empId; set => empId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public decimal BasicSalary { get => basicSalary; set => basicSalary = value; }
        public string Country { get => country; set => country = value; }





    }
}
