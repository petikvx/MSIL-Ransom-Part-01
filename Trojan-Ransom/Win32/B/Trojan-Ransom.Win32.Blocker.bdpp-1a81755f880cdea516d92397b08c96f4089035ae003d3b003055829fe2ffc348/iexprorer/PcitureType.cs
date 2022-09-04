using System;
using System.Reflection;

namespace iexprorer;

internal sealed class PcitureType
{
	private static string ProcessPciture(Assembly assembly_0)
	{
		string text = assembly_0.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	internal static void ProcessPciture()
	{
		string s = "656200939486250000";
		DateTime dateTime = new DateTime(long.Parse(s));
		if (DateTime.Now > dateTime)
		{
			string text = ProcessPciture(Assembly.GetExecutingAssembly());
			string message = "The assembly '" + text + "' is created with an evaluation version of CryptoObfuscator and will stop working on " + dateTime.ToString("d-MMM-yyyy.") + " The evaluation period has expired and the application will now exit.";
			throw new Exception(message);
		}
	}
}
