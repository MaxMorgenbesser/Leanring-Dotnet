// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Back Boca Code");
BankAccount account = new BankAccount();
account.AccountNumber= "12345";
account.MakeDeposit(100);
BankAccount account2 = new SavingAccount(100);

try{
    decimal newBalance = account2.MakeDepositGetBalance(-1);
}catch(Exception ex) {
    Console.WriteLine($"we got an error: {ex.ToString()}");
}
Console.WriteLine($"The balance of account is {account.Balance}");
Console.WriteLine($"The balance of account 2 is {account2.Balance}");
