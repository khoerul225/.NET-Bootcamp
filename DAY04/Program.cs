using static System.Console;
//  call call Employee
using DAY04.partOne;


/// <summary>
/// Cara Gampang OOP Dengamn Menganalogikan Tabel Buat Tabel
/// </summary>
// setiap create objek instan ubakabn opertor new
Employee emp1 = new Employee();
emp1.EmpId = 0001;
emp1.FirstName = "Bpk";
emp1.LastName = "Soekarno";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 1_000_000;
emp1.Country = "Blitar";
emp1.Role = "Civil Engineering ";



//cerate object employee with parameter 
Employee emp2 = new Employee(0002,"Bpk","Soeharto",new DateTime(),"Blitar");
emp2.Role = "Soldier";
Employee emp3 = new Employee(0003, "Bj", "Habibi   ", new DateTime(),100_0000, "Pariaman");
emp3.Role = "Engineer";
Employee emp4 = new Employee(0004, "Bj", "Megawati   ", new DateTime(), 100_0000, "Jakarta");
emp4.Role = "EIbu Rumah Tangga";
WriteLine(emp1.ToString());
WriteLine(emp2.ToString());
WriteLine(emp3.ToString());
WriteLine(emp4.ToString());
Console.WriteLine($"Total Employee\t   | {Employee.totalEmploye}");
Console.WriteLine($"Total Salary\t   | {Employee.totalSalary}");


//store to list
List<Employee> listEmployees = new List<Employee> {emp1,emp2,emp3,emp4};
foreach (var emp in listEmployees)
{
    WriteLine(emp.ToString());
}

ReadLine();