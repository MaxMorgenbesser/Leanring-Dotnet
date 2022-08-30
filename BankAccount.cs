public class BankAccount {
public string AccountNumber {get;set;}
public decimal Balance {get;set;}=0;

public BankAccount(){
AccountNumber="";
Balance=100;
}

public BankAccount(decimal newBalance){
    AccountNumber="";
    Balance=100;
}
public void MakeDeposit(decimal amount){
    if (amount <=0 ){
        throw new Exception ("no money left");
    }
    Balance+=amount;
}
public decimal MakeDepositGetBalance(decimal amount){
    MakeDeposit(amount);
    return Balance;
}
}
public class SavingAccount : BankAccount {
    public SavingAccount() : base()
    {
        Balance = 200;
    }
public SavingAccount(decimal amount) : base(amount){

}
}

