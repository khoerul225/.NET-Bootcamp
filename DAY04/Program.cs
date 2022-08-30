// call class empolyee
using static System.Console;
using PartOne;
using System.Globalization;
bool testing = false;

//create object instant , gunakan operator new
/*Employee emp1 = new Employee();
emp1.EmpId = 1000;
emp1.FirstName = "Khoerul";
emp1.LastName1 = "Mutaqin";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 7_000_000;
emp1.City1 = "Brebes";
emp1.Role = "Programmer";






//create oject employee with parameter constructor
Employee emp2 = new Employee(1001, "Happy", "Asmara    ", new DateTime(2022, 06, 12), 5_000_000, "Semarang", "Sales");
Employee emp3 = new Employee(1002, "Denny", "Caknan    ", new DateTime(2022, 06, 12), 5_000_000, "Madiun", "QA");
Employee emp4 = new Employee(1003, "Juang", "Astrajingga", new DateTime(2022, 06, 12), 5_000_000, "Bandung", "Engineering");
Employee emp5 = new Employee(1004, "Silvia", "Raudha    ", new DateTime(2022, 06, 12), 5_000_000, "Aceh", "Psikologi");
*//*empl.firstName = "Code"; //encapsulation menggunakan atribut class
empl.EmpId = 1001;*//*

WriteLine("======================29 Agustus 2022===========================================================================================");
WriteLine("===========================OOP==================================================================================================");
WriteLine("================================================================================================================================");

WriteLine(emp1.ToString());
WriteLine(emp2.ToString());
WriteLine(emp3.ToString());
WriteLine(emp4.ToString());
WriteLine(emp5.ToString());
WriteLine();
WriteLine("================================================================================================================================");
WriteLine($"Total employee : {Employee.totalEmployee}");
WriteLine($"total Basic Salary : {Employee.totalBasic.ToString("C", new CultureInfo("Id-ID"))}");
//merubah data salary
emp3.Role = "QA";
emp3.BasicSalary = 9_000_000;
WriteLine("================================================================================================================================");
//Create Object Class Programmer
Programmer prog1 = new Programmer(1005, "Fiki", "Fitrotul    ", new DateTime(2022, 06, 12), 5_600_000, "Tegal", 400_000);
Sales sales1 = new Sales(1006, "Rohman", "Picisan    ", new DateTime(2022, 06, 12), 3_000_000, "Medan", 500_000, 200_000);
QA qa1 = new QA(1007, "Fiersa", "Beeari    ", new DateTime(2022, 06, 12), 5_600_000, "Tegal", 10_000);

//store to list (mempermudah menampilkan menggunakan list)
List<Employee> listEmps = new List<Employee> { emp1, emp2, emp3, emp4, emp5, prog1,sales1,qa1};

foreach (var item in listEmps)
{
    WriteLine(item.ToString());
}

WriteLine();
WriteLine("================================================================================================================================");
WriteLine($"Total employee : {Employee.totalEmployee}");
WriteLine($"total Basic Salary : {Employee.totalBasic.ToString("C", new CultureInfo("Id-ID"))}");
WriteLine("================================================================================================================================");
*/
while (!testing)
{
    Console.Write("Masukan No Soal (1-3{4})");
    int no = Convert.ToInt32(Console.ReadLine());
    switch (no)
    {
        case 1:
            PartOne.Employee.No1();
            break;
        case 2:
            PartOne.Employee.No2();
            break;
        case 3:
            PartOne.Employee.No3();
            break;
        case 4:
            PartOne.Employee.No4();
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






