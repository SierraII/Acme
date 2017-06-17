using System;

namespace App.Acme
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			SystemDB db = new SystemDB();

			db.deposit("ACC1", Convert.ToDecimal(22));
			db.widthdraw("ACC1", Convert.ToDecimal(10));
			db.widthdraw("ACC5", Convert.ToDecimal(30000));
		}
	}
}
