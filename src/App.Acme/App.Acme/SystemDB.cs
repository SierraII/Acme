using System;
using System.Collections.Generic;
using App.Acme.Shared;

namespace App.Acme
{
	public class SystemDB
	{
		public List<Account> Accounts { get; set; }

		public SystemDB()
		{
			Accounts = new List<Account>();

			// quickly add 20 accounts
			for (int i = 0; i < 20; i++)
			{
				SavingsAccount savingsAccount = new SavingsAccount(accountID: i.ToString(), initialDeposit: Convert.ToDecimal(1000));
				Core.Context.log.d("SystemDB - savings account with ID " + i + " created with R1000.00 initial deposit...");
				Accounts.Add(savingsAccount);
			}

		}

		public void widthdraw(string accountID, decimal amount)
		{
			Account account = getAccount(accountID);
			account.withdraw(amount);
		}

		public void deposit(string accountID, decimal amount)
		{
			Account account = getAccount(accountID);
			account.deposit(amount);
		}

		public double getInterestRate(string accountID)
		{
			Account account = getAccount(accountID);
			return account.InterestRate;
		}


		public string getAccountType(string accountID)
		{
			Account account = getAccount(accountID);
			return account.GetType().Name;
		}

		private Account getAccount(string accountID)
		{
			Account account = Accounts.Find(x => x.AccountID == accountID);

			if (account == null)
			{
				throw new Exception("Account Not Found");
			}

			return account;
		}

	}
}
