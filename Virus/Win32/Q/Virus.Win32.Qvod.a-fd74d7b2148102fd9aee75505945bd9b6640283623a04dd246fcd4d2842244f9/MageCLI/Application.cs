using System;
using System.Resources;
using System.Security;

namespace MageCLI;

internal class Application
{
	private enum ProcessExitCodes
	{
		Success,
		ErrorInvalidArgument,
		ErrorUnknown
	}

	private static ResourceManager resources;

	public static ResourceManager Resources
	{
		get
		{
			if (resources == null)
			{
				resources = new ResourceManager(typeof(Application));
			}
			return resources;
		}
	}

	[STAThread]
	private static int Main(string[] args)
	{
		ProcessExitCodes result = ProcessExitCodes.Success;
		try
		{
			Command command = new Command(args);
			if (command.CanExecute())
			{
				command.Execute();
				return (int)result;
			}
			result = ProcessExitCodes.ErrorInvalidArgument;
			return (int)result;
		}
		catch (SecurityException)
		{
			string value = Resources.GetString("ErrorMessage") + ": " + Resources.GetString("SecurityMessage");
			Console.WriteLine(value);
			return (int)result;
		}
		catch (Exception ex2)
		{
			InternalError(ex2.Message, ex2.StackTrace);
			return 2;
		}
	}

	private static void InternalError(string message, string stackTrace)
	{
		string text = Resources.GetString("InternalError");
		if (text == null)
		{
			text = "Internal Error:";
		}
		Console.WriteLine(text + " " + message);
	}

	public static void ReportException(Exception ex)
	{
		Console.WriteLine(ex.Message);
	}

	public static void PrintOutputMessage(string manifestname, string message)
	{
		if (string.IsNullOrEmpty(manifestname))
		{
			Console.WriteLine(message);
		}
		else
		{
			Console.WriteLine(manifestname + " " + message);
		}
	}

	public static void PrintHelpMessage()
	{
		Console.WriteLine(Resources.GetString("HelpTerse"));
	}

	public static void PrintVerboseHelpMessage()
	{
		Console.WriteLine(Resources.GetString("HelpVerbose"));
	}

	internal static Processors GetProcessor(string processor)
	{
		Processors result = Processors.Undefined;
		try
		{
			result = (Processors)Enum.Parse(typeof(Processors), processor, ignoreCase: true);
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	internal static void PrintInvalidOptionErrorMessage(string option, string allowed1, string allowed2)
	{
		string text = string.Format(Resources.GetString("InvalidOption") + " ", option);
		text += allowed1;
		if (allowed2 != null)
		{
			text += Resources.GetString("InvalidOptionConjuction");
			text += allowed2;
		}
		Console.WriteLine(text);
	}

	internal static void PrintErrorMessage(ErrorMessages error)
	{
		PrintErrorMessage(error, null);
	}

	internal static void PrintErrorMessage(ErrorMessages error, string parameter)
	{
		string value;
		if (parameter == null)
		{
			value = Resources.GetString(error.ToString());
		}
		else
		{
			value = Resources.GetString(error.ToString());
			value = string.Format(value, parameter);
		}
		Console.WriteLine(value);
		if (error == ErrorMessages.InvalidProcessor)
		{
			for (int i = 0; i < 4; i++)
			{
				Processors processors = (Processors)i;
				Console.Write(processors.ToString() + " ");
			}
		}
	}
}
