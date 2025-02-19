
namespace CSharpOOP;

    

public class BankAccount
{

    private static int accountNumberSeed = 1234567890;
    private List<Transaction> allTransactions = new List<Transaction>();



    public string? Numbers { get;}
    public string? Owner { get; set;}
    public decimal Balance 
    {
         get
         {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
         }
         
         
    }

    // A constructor is a special method that is called when an instance of a class is created.

    public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name; // this keyword is used to refer to the current instance of the class.
        
        MakeDeposit(initialBalance, DateTime.Now, note: "Initial balance");

        this.Numbers = accountNumberSeed.ToString();
        accountNumberSeed++;


    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if(amount<=0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount),
            message:"Amount of deposit must be positive");
        }

        var deposit = new Transaction(amount,date,note);

        allTransactions.Add(deposit);

    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {

        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount),
            message: "Amount of withdrawal must be positive");
        }

        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }


        var withdrawal = new Transaction(-amount,date,note);
        allTransactions.Add(withdrawal);
    }


}