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

			// quickly add some accounts
			for (int i = 0; i < 5; i++)
			{
				SavingsAccount savingsAccount = new SavingsAccount("ACC" + i, 1000.00m, "HOLD" + i);
				Core.Context.log.d("SystemDB - savings account with ID " + i + " created with R1000.00 initial deposit...");
				Accounts.Add(savingsAccount);
			}

			for (int i = 5; i < 10; i++)
			{
				CurrentAccount currentAccount = new CurrentAccount("ACC" + i, 5000.00m, 25000.000m, "HOLD" + i);
				Core.Context.log.d("SystemDB - current account with ID " + i + " created...");
				Accounts.Add(currentAccount);
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

		public void transfer(string accountIDFrom, string accountIDTo, decimal amount)
		{
			Account accountFrom = getAccount(accountIDFrom);
			Account accountTo = getAccount(accountIDTo);

			accountFrom.withdraw(amount);
			accountTo.deposit(amount);
		}

		private Account getAccount(string accountID)
		{
			Account account = Accounts.Find(x => x.AccountID == accountID);

			if (account == null)
			{
				throw new Exception("AccountNotFoundException");
			}

			return account;
		}

	}
}
