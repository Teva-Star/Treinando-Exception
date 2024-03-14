using TreinodeExeception.Modelos;
using TreinodeExeception.Modelos.Exceptions;

try
{

    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holde: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double limited = double.Parse(Console.ReadLine());

    Account acc = new Account(number, holder, balance, limited);
    Console.Write("Enter amount for Deposit  :");
    double deposit = double.Parse(Console.ReadLine());
    acc.Deposito(deposit);
    Console.WriteLine(acc);
    Console.Write("Enter amount for withrdraw: ");
    double withrdraw = double.Parse(Console.ReadLine());
    acc.Withdraw(withrdraw);
    Console.WriteLine(acc);


    Console.Write("");
} catch(DomainException E) { Console.WriteLine(E.Message);

}