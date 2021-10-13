/*
 * Quando usar o Decorator?
 * 
 * Sempre que percebemos que temos comportamentos que podem ser compostos por comportamentos de outras classes envolvidas em uma mesma hierarquia, 
 * como foi o caso dos impostos, que podem ser composto por outros impostos. 
 * O Decorator introduz a flexibilidade na composição desses comportamentos, bastando escolher no momento da instanciação, 
 * quais instancias serão utilizadas para realizar o trabalho.
 */

using DesignPatterns.Decorator.Example2.Account;
using DesignPatterns.Decorator.Example2.Filter;
using DesignPatterns.Decorator.Sale;
using DesignPatterns.Decorator.Tax;

/*
 * TESTE 1
 */
var order = new Order();
order.AddItem(new OrderItem("Pencil", 1000));

TaxCalculator onlyIss = new Iss();
TaxCalculator onlyIcms = new Icms();
TaxCalculator issPlusIcms = new Iss(new Icms());

Console.WriteLine($"Iss Value = {onlyIss.Calculate(order)}");
Console.WriteLine($"Icms Value = {onlyIcms.Calculate(order)}");
Console.WriteLine($"Iss + Icms Value = {issPlusIcms.Calculate(order)}");
Console.ReadKey();
Console.Clear();

/*
 * TESTE 2
 */
var accounts = new List<AccountEntity>();
accounts.Add(new AccountEntity("Name_01", 1, "0001", 50, DateTime.Now.AddDays(-60))); //Low
accounts.Add(new AccountEntity("Name_02", 2, "0001", 5000000, DateTime.Now.AddDays(-62))); //High
accounts.Add(new AccountEntity("Name_03", 3, "0001", 500, DateTime.Now)); //Today
accounts.Add(new AccountEntity("Name_04", 4, "0001", 50, DateTime.Now.AddDays(-5))); //Low and Today
accounts.Add(new AccountEntity("Name_05", 5, "0001", 1000, DateTime.Now.AddDays(-90))); //OK

var filterAccount = new Dictionary<string, FilterAccount>
{
    {"Low Filter",  new LowFilter()},
    {"High Filter",  new HighFilter()},
    {"New Account Filter",  new NewAccountFilter()},
    {"All Filters",  new LowFilter(new HighFilter(new NewAccountFilter()))},
};

foreach (var item in filterAccount)
{
    Console.WriteLine($"Applied Filter: {item.Key}");

    var filteredAccounts = item.Value.Filter(accounts);
    if (filteredAccounts == null || filteredAccounts.Count < 1)
    {
        Console.WriteLine("Sem registros");
        Console.ReadKey();
        Console.Clear();
        continue;
    }

    Console.WriteLine("Name - Balance - Creation Date");
    foreach (var filteredAccount in filteredAccounts)
    {
        Console.WriteLine($"{filteredAccount.Name} - {filteredAccount.Balance} - {filteredAccount.CreationDate}");
    }

    Console.ReadKey();
    Console.Clear();
}

