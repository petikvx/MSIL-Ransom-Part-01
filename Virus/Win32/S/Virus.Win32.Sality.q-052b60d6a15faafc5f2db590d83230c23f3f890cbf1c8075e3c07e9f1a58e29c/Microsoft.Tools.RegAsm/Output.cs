using System;

namespace Microsoft.Tools.RegAsm;

internal static class Output
{
	private static bool s_bSilent;

	internal static void WriteError(string message)
	{
		WriteError(message, 0);
	}

	internal static void WriteError(string message, int errorNumber)
	{
		string format = "RegAsm : error RA{1:0000} : {0}";
		Console.Error.WriteLine(format, message, errorNumber);
	}

	internal static void WriteError(Exception e)
	{
		string text = "";
		text = ((e.Message == null) ? (text + e.GetType().ToString()) : (text + e.Message));
		WriteError(text);
	}

	internal static void WriteWarning(string message)
	{
		if (!s_bSilent)
		{
			string format = "RegAsm : warning RA0000 : {0}";
			Console.Error.WriteLine(format, message);
		}
	}

	internal static void WriteInfo(string message)
	{
		if (!s_bSilent)
		{
			Console.WriteLine(message);
		}
	}

	internal static void SetSilent(bool silent)
	{
		s_bSilent = silent;
	}
}
