
namespace CSharpOOP;

    

public class BankAccount
{
    public string? Numbers { get;}
    public string? Owner { get; set;}
    public decimal Balance { get;}

    // A constructor is a special method that is called when an instance of a class is created.

    public BankAccount()
    {
        Console.WriteLine("Constructor called");
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {}

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {}


}