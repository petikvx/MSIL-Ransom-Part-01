using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class ConsoleEntryPoint
{
	private enum Operations
	{
		None,
		Help,
		Change
	}

	private WsatConfiguration newConfig;

	private WsatConfiguration previousConfig;

	private Operations operation;

	private bool restartRequired;

	private bool showRequired;

	private string virtualServer;

	[STAThread]
	public static int Main(string[] args)
	{
		try
		{
			ValidateUICulture();
			PrintBanner();
			ConsoleEntryPoint consoleEntryPoint = new ConsoleEntryPoint(args);
			consoleEntryPoint.Run();
			return 0;
		}
		catch (WsatAdminException ex)
		{
			Console.WriteLine();
			Console.WriteLine(ex.Message);
			return (int)ex.ErrorCode;
		}
		catch (Exception ex2)
		{
			Console.WriteLine(SR.GetString("UnexpectedError", ex2.Message));
			return 1;
		}
	}

	private static void PrintBanner()
	{
		Console.WriteLine();
		Console.WriteLine(SR.GetString("ConsoleBannerLine01"));
		Console.WriteLine(SR.GetString("ConsoleBannerLine02", CommonResStrings.WcfTrademarkForCmdLine, "3.0.4506.648"));
		Console.WriteLine(SR.GetString("ConsoleBannerLine03", CommonResStrings.CopyrightForCmdLine));
	}

	private static void PrintUsage()
	{
		OptionUsage.Print();
	}

	private ConsoleEntryPoint(string[] argv)
	{
		List<string> arguments = PrescanArgs(argv);
		if (operation != Operations.Help)
		{
			previousConfig = new WsatConfiguration(null, virtualServer, null, minimalWrite: true);
			previousConfig.LoadFromRegistry();
			newConfig = new WsatConfiguration(null, virtualServer, previousConfig, minimalWrite: true);
			ParseArgs(arguments);
		}
	}

	private void Run()
	{
		switch (operation)
		{
		default:
			PrintUsage();
			break;
		case Operations.Change:
			newConfig.ValidateThrow();
			if (restartRequired)
			{
				Console.WriteLine(SR.GetString("InfoRestartingMSDTC"));
			}
			newConfig.Save(restartRequired);
			if (restartRequired)
			{
				Console.WriteLine(SR.GetString("InfoRestartedMSDTC"));
			}
			if (newConfig.IsClustered)
			{
				Console.WriteLine(SR.GetString("ClusterConfigUpdatedSuccessfully"));
			}
			else
			{
				Console.WriteLine(SR.GetString("ConfigUpdatedSuccessfully"));
			}
			break;
		case Operations.None:
			break;
		}
		if (operation != Operations.Change && restartRequired)
		{
			try
			{
				MsdtcWrapper msdtcWrapper = newConfig.GetMsdtcWrapper();
				Console.WriteLine(SR.GetString("InfoRestartingMSDTC"));
				msdtcWrapper.RestartDtcService();
				Console.WriteLine(SR.GetString("InfoRestartedMSDTC"));
			}
			catch (WsatAdminException)
			{
				throw;
			}
			catch (Exception ex2)
			{
				if (Utilities.IsCriticalException(ex2))
				{
					throw;
				}
				throw new WsatAdminException(WsatAdminErrorCode.DTC_RESTART_ERROR, SR.GetString("ErrorRestartMSDTC"), ex2);
			}
		}
		if (showRequired)
		{
			Console.WriteLine();
			Console.WriteLine(SR.GetString("ConsoleShowInformation"));
			Console.WriteLine((operation == Operations.Change) ? newConfig.ToString() : previousConfig.ToString());
		}
	}

	private List<string> PrescanArgs(string[] argv)
	{
		List<string> list = new List<string>();
		if (argv.Length < 1)
		{
			operation = Operations.Help;
		}
		else
		{
			operation = Operations.None;
			foreach (string rawArg in argv)
			{
				string text = ProcessArg(rawArg);
				if (!Utilities.SafeCompare(text, "help") && !Utilities.SafeCompare(text, "h") && !Utilities.SafeCompare(text, "?"))
				{
					string value;
					if (Utilities.SafeCompare(text, "show"))
					{
						showRequired = true;
					}
					else if (Utilities.SafeCompare(text, "restart"))
					{
						restartRequired = true;
					}
					else if (Utilities.SafeCompare(ArgumentsParser.ExtractOption(text, out value), "virtualServer"))
					{
						virtualServer = value;
					}
					else
					{
						list.Add(text);
					}
					continue;
				}
				operation = Operations.Help;
				break;
			}
		}
		return list;
	}

	private void ParseArgs(List<string> arguments)
	{
		ArgumentsParser argumentsParser = new ArgumentsParser(newConfig);
		foreach (string argument in arguments)
		{
			if (argumentsParser.ParseOptionAndArgument(argument))
			{
				operation = Operations.Change;
				continue;
			}
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_ARGUMENT, SR.GetString("ErrorArgument"));
		}
		argumentsParser.ValidateArgumentsThrow();
	}

	private static string ProcessArg(string rawArg)
	{
		if (string.IsNullOrEmpty(rawArg))
		{
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_ARGUMENT, SR.GetString("ErrorArgument"));
		}
		if (rawArg[0] != '/' && rawArg[0] != '-')
		{
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_ARGUMENT, SR.GetString("ErrorArgument"));
		}
		return rawArg.Substring(1);
	}

	private static void ValidateUICulture()
	{
		Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentUICulture.GetConsoleFallbackUICulture();
		if (Console.OutputEncoding.CodePage != Encoding.UTF8.CodePage && Console.OutputEncoding.CodePage != Thread.CurrentThread.CurrentUICulture.TextInfo.OEMCodePage)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
		}
	}
}
