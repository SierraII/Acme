using System;
namespace App.Acme.Shared
{
	public class CurrentAccount : Account, IAccount
	{
		// defaulting the interest rate to 9%
		public CurrentAccount(string accountID, decimal initialDeposit) : base(accountID, initialDeposit, 0.09)
		{

		}

		public override void deposit(decimal amount)
		{
			Core.Context.log.i("current depositing: " + amount);
			base.deposit(amount);
		}

		public override void withdraw(decimal amount)
		{
			Core.Context.log.i("current withdrawing: " + amount);
			base.withdraw(amount);
		}
	}
}
