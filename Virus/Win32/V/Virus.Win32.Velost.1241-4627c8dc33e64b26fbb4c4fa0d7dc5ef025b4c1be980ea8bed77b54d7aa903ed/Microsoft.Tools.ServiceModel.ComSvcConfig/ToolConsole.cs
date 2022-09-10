using System;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal static class ToolConsole
{
	private static bool verbose;

	public static bool Verbose
	{
		set
		{
			verbose = value;
		}
	}

	internal static void WriteQueryLine(string str)
	{
		Console.WriteLine(str);
	}

	internal static void WriteLine(string str)
	{
		Console.WriteLine(str);
	}

	internal static void WriteError(Exception e)
	{
		WriteError(e, SR.GetString("Error"));
	}

	internal static void WriteWarning(string message)
	{
		if (verbose)
		{
			Console.Write(SR.GetString("Warning"));
			Console.WriteLine(message);
		}
	}

	internal static void WriteNonVerboseWarning(string message)
	{
		Console.Write(SR.GetString("Warning"));
		Console.WriteLine(message);
	}

	internal static void WriteError(string errMsg, string prefix)
	{
		Console.Error.Write(prefix);
		Console.Error.WriteLine(errMsg);
	}

	internal static void WriteError(Exception e, string prefix)
	{
		WriteError(e.Message, prefix);
		if (e.InnerException != null)
		{
			WriteError(e.InnerException, "    ");
		}
	}

	internal static void WriteDetailedException(Exception e, string prefix)
	{
		WriteError(e, prefix);
		if (e.InnerException != null)
		{
			WriteError(e.InnerException, "    ");
		}
	}
}
