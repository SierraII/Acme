using App.Acme.Utils;

namespace App.Acme.Core
{
	public static class Context
	{
		// any static global libs are instanitated within this context class
		// i.e. if we have an FTP connection we can share it across projects here
		public static Logcat log { get; set; }

		static Context()
		{
			log = new Logcat();
		}
	}
}
