using System;
namespace App.Acme.Shared
{
	public interface IAccount
	{
		void deposit(decimal amount);
		void withdraw(decimal amount);
	}
}
