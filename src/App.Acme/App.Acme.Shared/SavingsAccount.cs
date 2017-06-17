using System;
namespace App.Acme.Shared
{
	public class SavingsAccount : Account, IAccount
	{

		// defaulting the interest rate of a svings account to 3%
		public SavingsAccount(string accountID, decimal initialDeposit, string accountHolder) : base(accountID, initialDeposit, 0.03, accountHolder)
		{
			if (initialDeposit < 1000)
			{
				throw new Exception("InitialDepositTooLowException");
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
				throw new Exception("WithdrawalAmountTooLargeException");
			}
			else
			{
				Core.Context.log.i("Savings Account - ID " + this.AccountID + " withdrawing R" + amount);
				base.withdraw(amount);
			}

		}
	}
}
