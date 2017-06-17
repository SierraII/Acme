using System;
namespace App.Acme.Shared
{
	public abstract class Account
	{

		public string AccountID { get; }
		public decimal Amount { get; private set; }
		public double InterestRate { get; }

		public Account(string accountID, decimal initialDeposit, double interestRate)
		{
			this.Amount = initialDeposit;
			this.AccountID = accountID;
			this.InterestRate = interestRate;
		}

		public virtual void deposit(decimal amount)
		{
			this.Amount += amount;
			Core.Context.log.i("Base Account - ID " + this.AccountID + " deposited R" + amount + ". Total = R" + this.Amount);
		}

		public virtual void withdraw(decimal amount)
		{
			this.Amount -= amount;
			Core.Context.log.i("Base Account - ID " + this.AccountID + " withdrew R" + amount + ". Total = R" + this.Amount);
		}

		internal decimal getAmount()
		{
			return this.Amount;
		}

	}
}
