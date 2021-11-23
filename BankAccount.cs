 using System;
 
 abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount()
        {
            Balance = 1000;
        }

         public BankAccount(double balance)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
          Balance = Balance + amount;
          Console.WriteLine("Your current balance is " + Balance);
        }

        public virtual void Withdraw(double amount)
        {
          if(Balance > amount)
          {
            Balance = Balance - amount;
            Console.WriteLine("Your current balance is " + Balance);
          }
          else
          {
            Console.WriteLine("Unable to withdraw. Amount is greater than balance");
          }
        }
        
        public abstract void CalculateInterest();

    }