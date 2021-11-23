using System;

class SavingsAccount : BankAccount
{
  public override void CalculateInterest()
  {
    base.Balance = base.Balance + (base.Balance + (.05*(DateTime.Today.Year - DateCreated.Year)));
    Console.WriteLine("Your savings balance plus interest is " + base.Balance);

  }

  public override void Withdraw(double amount)
  {
    if(base.Balance < 2000)
    {
      Console.WriteLine("Insufficient savings balance");
    }
    else
    {
      base.Withdraw(amount);
    }

  }
      
}