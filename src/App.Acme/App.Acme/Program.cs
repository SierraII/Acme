using System;

namespace App.Acme
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			SystemDB bd = new SystemDB();

			bd.deposit("1", Convert.ToDecimal(22));
			bd.widthdraw("1", Convert.ToDecimal(10));

		}
	}
}
