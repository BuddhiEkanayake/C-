using CSharpOOP;

BankAccount account = new BankAccount(name: "John Doe", initialBalance: 1000);

Console.WriteLine(account.Owner);
Console.WriteLine(account.Balance);

Console.WriteLine($"Account owner is-{account.Owner} and account number is-{account.Numbers}");

BankAccount account2 = new BankAccount(name:"Nirmali Herath", initialBalance: 2000);

Console.WriteLine($"Account Owner is-{account2.Owner} and account number is-{account2.Numbers}");