using System;
namespace App.Acme.Shared
{
	public class SavingsAccount : Account, IAccount
	{
		// withdraw:
		// minimum balance of R1000.00
		// account’s balance is decreased by the amount withdrawn
		// deposit:
		// can only be opened if you deposit at least R1000.00
		// account’s balance is increased by the amount deposited

		// defaulting the interest rate of a svings account to 3%
		public SavingsAccount(string accountID, decimal initialDeposit) : base(accountID, initialDeposit, 0.03)
		{
			if (initialDeposit < 1000)
			{
				throw new ApplicationException("Initial Deposit Too Low");
			}
		}

		public override void deposit(decimal amount)
		{
			Core.Context.log.i("Savings Account - ID " + this.AccountID + " depositing R" + amount);
			base.deposit(amount);
		}

		public override void withdraw(decimal amount)
		{

			if (getAmount() - amount < 1000)
			{
				throw new ApplicationException("Withdrawal Amount Too Large");
			}
			else
			{
				Core.Context.log.i("Savings Account - ID " + this.AccountID + " withdrawing R" + amount);
				base.withdraw(amount);
			}

		}
	}
}
