using System;
namespace App.Acme.Shared
{
	public class CurrentAccount : Account, IAccount
	{
		public decimal OverDraftLimit { get; set; }
		public decimal BankOverDraftLimit = 100000.00m;

		// defaulting the interest rate to 9%
		public CurrentAccount(string accountID, decimal initialDeposit, decimal overDraftLimit, string accountHolder) : base(accountID, initialDeposit, 0.09, accountHolder)
		{
			if (overDraftLimit > BankOverDraftLimit)
			{
				throw new Exception("OverDraftLimitTooLargeException");
			}

			this.OverDraftLimit = overDraftLimit;
		}

		public override void deposit(decimal amount)
		{
			Core.Context.log.i("Current Account - ID " + this.AccountID + " depositing R" + amount);
			base.deposit(amount);
		}

		public override void withdraw(decimal amount)
		{
			if (amount > (getAmount() + this.OverDraftLimit))
			{
				throw new Exception("AmountTooLargeException");
			}
			else
			{
				Core.Context.log.i("Current Account - ID " + this.AccountID + " withdrawing R" + amount);
				base.withdraw(amount);
			}
		}
	}
}
