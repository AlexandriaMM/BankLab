using System;

class CheckingAccount : BankAccount
{
  public override void CalculateInterest()
  {
    base.Balance = base.Balance + (base.Balance +(.005*(DateTime.Today.Year - DateCreated.Year)));
    Console.WriteLine("Your checking balance plus interest is " + base.Balance);
    
  } 

  public override void Withdraw(double amount)
  {
    base.Withdraw(amount);
  }

      
}