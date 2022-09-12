using System;

namespace HtmlAgilityPack;

internal class HtmlCmdLine
{
	internal static bool Help;

	static HtmlCmdLine()
	{
		Help = false;
		ParseArgs();
	}

	internal static string GetOption(string name, string def)
	{
		string ArgValue = def;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		for (int i = 1; i < commandLineArgs.Length; i++)
		{
			GetStringArg(commandLineArgs[i], name, ref ArgValue);
		}
		return ArgValue;
	}

	internal static string GetOption(int index, string def)
	{
		string ArgValue = def;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		int num = 0;
		int num2 = 1;
		while (true)
		{
			if (num2 < commandLineArgs.Length)
			{
				if (GetStringArg(commandLineArgs[num2], ref ArgValue))
				{
					if (index == num)
					{
						break;
					}
					ArgValue = def;
					num++;
				}
				num2++;
				continue;
			}
			return ArgValue;
		}
		return ArgValue;
	}

	internal static bool GetOption(string name, bool def)
	{
		bool ArgValue = def;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		for (int i = 1; i < commandLineArgs.Length; i++)
		{
			GetBoolArg(commandLineArgs[i], name, ref ArgValue);
		}
		return ArgValue;
	}

	internal static int GetOption(string name, int def)
	{
		int ArgValue = def;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		for (int i = 1; i < commandLineArgs.Length; i++)
		{
			GetIntArg(commandLineArgs[i], name, ref ArgValue);
		}
		return ArgValue;
	}

	private static void GetBoolArg(string Arg, string Name, ref bool ArgValue)
	{
		if (Arg.Length >= Name.Length + 1 && ('/' == Arg[0] || '-' == Arg[0]) && Arg.Substring(1, Name.Length).ToLowerInvariant() == Name.ToLowerInvariant())
		{
			ArgValue = true;
		}
	}

	private static void GetIntArg(string Arg, string Name, ref int ArgValue)
	{
		if (Arg.Length < Name.Length + 3 || ('/' != Arg[0] && '-' != Arg[0]) || !(Arg.Substring(1, Name.Length).ToLowerInvariant() == Name.ToLowerInvariant()))
		{
			return;
		}
		try
		{
			ArgValue = Convert.ToInt32(Arg.Substring(Name.Length + 2, Arg.Length - Name.Length - 2));
		}
		catch
		{
		}
	}

	private static bool GetStringArg(string Arg, ref string ArgValue)
	{
		if ('/' != Arg[0] && '-' != Arg[0])
		{
			ArgValue = Arg;
			return true;
		}
		return false;
	}

	private static void GetStringArg(string Arg, string Name, ref string ArgValue)
	{
		if (Arg.Length >= Name.Length + 3 && ('/' == Arg[0] || '-' == Arg[0]) && Arg.Substring(1, Name.Length).ToLowerInvariant() == Name.ToLowerInvariant())
		{
			ArgValue = Arg.Substring(Name.Length + 2, Arg.Length - Name.Length - 2);
		}
	}

	private static void ParseArgs()
	{
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		for (int i = 1; i < commandLineArgs.Length; i++)
		{
			GetBoolArg(commandLineArgs[i], "?", ref Help);
			GetBoolArg(commandLineArgs[i], "h", ref Help);
			GetBoolArg(commandLineArgs[i], "help", ref Help);
		}
	}
}
