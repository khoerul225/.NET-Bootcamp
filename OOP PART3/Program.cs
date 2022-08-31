using static System.Console;
using OOP_PART3;


/// <summary>
/// Kodingan terbanyak di program dan custmer
/// 
/// </summary>

Person yuli = new Customer ("Yuli", "Ayu", "yuliAyu@gmail.com", new DateTime(1998,4,24), "110-110");
Person widi = new Customer ("Widi", "Amalia", "widiAmalia@gmail.com", new DateTime(1998,09,30),"110-111");
Person rini = new Customer ("Rini", "Marlina", "riniMarlina@gmail.com", new DateTime(1998,08,04),"110-112");


var listOfCustomer = new List<Person> {yuli,widi,rini};

var incomeYuli = new Dictionary<string, decimal> 
{
{"Kontrakan",20_000_0000},
{"Toko",10_000_0000}
};

/*yuli.TotalIncome(incomeYuli);
*/

yuli.TotalRevenue = yuli.TotalIncome(incomeYuli);



var incomeWidi = new Dictionary<string, decimal>
{
{"Kosan",10_000_0000},
{"Jual Online",10_000_0000}
};
widi.TotalRevenue = widi.TotalIncome(incomeWidi);


var incomeRini = new Dictionary<string, decimal>
{
{"Supermarket",10_000_0000},
{"Rental Ps",10_000_0000}
};

rini.TotalRevenue = rini.TotalIncome(incomeRini);


foreach (var item in listOfCustomer)
{
    WriteLine(item);
}

LinQ.IntroLinQ();