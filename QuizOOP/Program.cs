// call class empolyee
using static System.Console;
using QuizOOP;
using System.Globalization;
bool testing = false;

//create object instant , gunakan operator new
Transportation trans1 = new Transportation("D 1001 UM", 2015,"SUV",600_0000 );
Transportation trans2 = new Transportation("D 1002 UM", 2019, "SUV", 600_0000);
Transportation trans3 = new Transportation("D 1002 UM", 2018, "TAXI", 230_000);
Transportation trans4 = new Transportation("D 87 UK", 2018, "TAXI", 550_000);
Transportation trans5 = new Transportation("D 55 UJ", 2016, "ANGKOT", 157_0000);
Transportation trans6 = new Transportation("D 55 UJ", 2016, "ANGKOT", 180_0000);


Suv prog1 = new Suv ("D 55 UJ", 2016, "ANGKOT", 180_0000,10_000,10_0000);

//create oject Transportation with parameter constructor
//store to list (mempermudah menampilkan menggunakan list)
List<Transportation> listEmps = new List<Transportation> { trans1,trans2,trans3,trans4,trans5,trans6};

foreach (var item in listEmps)
{
    WriteLine(item.ToString());
}

WriteLine($"Total employee : {Transportation.t}");


Console.ReadLine();






