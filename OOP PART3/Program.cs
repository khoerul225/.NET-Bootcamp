using static System.Console;
using OOP_PART3;


/// <summary>
/// Kodingan terbanyak di program dan custmer
/// 
/// </summary>

Person yuli = new Customer ("Yuli", "Ayu", "yuliAyu@gmail.com", new DateTime(1998,4,24), "110-110");
Person widi = new Customer ("Widi", "Amalia", "widiAmalia@gmail.com", new DateTime(1998,09,30),"110-111");
Person rini = new Customer ("Rini", "Marlina", "riniMarlina@gmail.com", new DateTime(1998,08,04),"110-112");

//Suber data
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




WriteLine("================================Revenue Highest==================================================");
var listRange = listOfCustomer.Where(x => x.TotalRevenue < 300_000_000).ToList();
foreach (var item in listRange)
{
    WriteLine(item.ToString());
}

WriteLine();

var listMin = listOfCustomer.Min(x => x.TotalRevenue);
WriteLine($"Cust Min Revenue : {listMin}");

var listMax = listOfCustomer.Max(x => x.TotalRevenue);
WriteLine($"Cust Max Revenue : {listMax}");



var listThenMax = listOfCustomer.Where(x => x.TotalRevenue<listMax);
WriteLine("================================Revenue LowerThen Highest==================================================");
foreach (var item in listThenMax)
{
    WriteLine(item.ToString());
}

//Construktor adalah epenghubung kesemua Class
WriteLine("================================Select==================================================");
var query = listOfCustomer.Select
(cust=>
    new
    {
        FullName = cust.FirstName + " " + cust.LastName,
        Email = cust.Email,
        TotalRevenue = cust.TotalRevenue
    }
);

/// Kurung Biasa

foreach (var item in query)
{
    WriteLine(item);
}





/*LinQ.IntroLinQ();*/