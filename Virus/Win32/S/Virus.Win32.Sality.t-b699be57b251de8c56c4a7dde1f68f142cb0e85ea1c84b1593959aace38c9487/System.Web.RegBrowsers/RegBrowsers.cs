using System.Configuration;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Web.Configuration;

namespace System.Web.RegBrowsers;

internal class RegBrowsers
{
	private const int leftMargin = 4;

	private static bool _installMode;

	private static bool _showDetailUsage;

	private static int maxLineLength = 80;

	public static int Main(string[] args)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		try
		{
			maxLineLength = Console.BufferWidth;
		}
		catch
		{
		}
		SetThreadUICulture();
		Console.WriteLine(SR.GetString("Header_text"));
		Console.WriteLine(SR.GetString("Copyright"));
		if (args.Length == 1 && ParseArguments(args))
		{
			BrowserCapabilitiesCodeGenerator val = new BrowserCapabilitiesCodeGenerator();
			try
			{
				string text = HttpRuntime.get_ClrInstallDirectory() + "\\config\\browsers";
				DirectoryInfo directoryInfo = new DirectoryInfo(text);
				if (!directoryInfo.Exists)
				{
					DumpError("1001", SR.GetString("Directory_does_not_exist", text));
					return 1;
				}
				if (!_installMode)
				{
					try
					{
						if (!val.Uninstall())
						{
							DumpError("1002", SR.GetString("BrowserAssembly_Not_Installed"));
						}
						else
						{
							Console.WriteLine(SR.GetString("RegBrowser_uninstalled"));
						}
					}
					catch (Exception)
					{
						DumpError("1003", SR.GetString("Uninstallation_failed"));
						return 1;
					}
					return 0;
				}
				FileInfo[] files = directoryInfo.GetFiles("*.browser");
				if (files != null && files.Length != 0)
				{
					val.Create();
					Console.WriteLine(SR.GetString("RegBrowser_installed"));
					return 0;
				}
				DumpError("1004", SR.GetString("Directory_has_no_browser_files", text));
				return 1;
			}
			catch (Exception ex2)
			{
				Exception ex3 = GetFormattableException(ex2);
				if (ex3 == null)
				{
					ex3 = ex2;
				}
				ConfigurationException val2 = (ConfigurationException)(object)((ex3 is ConfigurationException) ? ex3 : null);
				if (val2 != null)
				{
					DumpError("ASPCONFIG", val2.get_Filename(), val2.get_Line(), val2.get_BareMessage());
					return 1;
				}
				HttpParseException val3 = (HttpParseException)(object)((ex3 is HttpParseException) ? ex3 : null);
				if (val3 != null)
				{
					DumpError("ASPPARSE", val3.get_VirtualPath(), val3.get_Line(), ((Exception)(object)val3).Message);
					return 1;
				}
				DumpError("ASPRUNTIME", null, 0, ex3.Message);
			}
			return 1;
		}
		ShowUsage();
		return 1;
	}

	private static void DumpError(string errorNumber, string message)
	{
		DumpError(errorNumber, null, 0, message);
	}

	private static void DumpError(string errorNumber, string filename, int line, string message)
	{
		if (filename != null)
		{
			Console.Write(filename);
			Console.Write("(" + line + "): ");
		}
		Console.Write(errorNumber + ": ");
		Console.WriteLine(message);
	}

	private static Exception GetFormattableException(Exception e)
	{
		if (!(e is ConfigurationException) && !(e is HttpParseException))
		{
			Exception innerException = e.InnerException;
			if (innerException == null)
			{
				return null;
			}
			return GetFormattableException(innerException);
		}
		return e;
	}

	private static bool ParseArguments(string[] args)
	{
		if (args.Length == 0)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < args.Length)
			{
				string text = args[0];
				if (text.Length != 2 || (text[0] != '-' && text[0] != '/'))
				{
					break;
				}
				text = text.Substring(1, 1);
				if (!string.Equals(text, "i", StringComparison.OrdinalIgnoreCase))
				{
					if (!string.Equals(text, "h", StringComparison.OrdinalIgnoreCase) && !string.Equals(text, "?", StringComparison.OrdinalIgnoreCase))
					{
						if (string.Equals(text, "u", StringComparison.OrdinalIgnoreCase))
						{
							num++;
							continue;
						}
						return true;
					}
					_showDetailUsage = true;
					return false;
				}
				_installMode = true;
				return true;
			}
			return true;
		}
		return false;
	}

	private static void SetThreadUICulture()
	{
		Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentUICulture.GetConsoleFallbackUICulture();
		if (Console.OutputEncoding.CodePage != 65001 && Console.OutputEncoding.CodePage != Thread.CurrentThread.CurrentUICulture.TextInfo.OEMCodePage && Console.OutputEncoding.CodePage != Thread.CurrentThread.CurrentUICulture.TextInfo.ANSICodePage)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
		}
	}

	private static void ShowUsage()
	{
		if (!_showDetailUsage)
		{
			Console.WriteLine("aspnet_regbrowsers [-? | -i | -u]");
			return;
		}
		Console.WriteLine(SR.GetString("Usage"));
		Console.WriteLine("aspnet_regbrowsers [-? | -i | -u]");
		DisplaySwitchWithHelp("-?", SR.GetString("questionmark_help"));
		DisplaySwitchWithHelp("-i", SR.GetString("RegBrowser_install_usage"));
		DisplaySwitchWithHelp("-u", SR.GetString("RegBrowser_uninstall_usage"));
	}

	private static void DisplaySwitchWithHelp(string switchString, string stringHelpString)
	{
		Console.Write(switchString);
		DisplayWordWrappedString(stringHelpString, switchString.Length, 4);
	}

	private static void DisplayWordWrappedString(string s, int currentOffset, int leftMargin)
	{
		string[] array = s.Split(new char[1] { ' ' });
		bool flag = true;
		string[] array2 = array;
		foreach (string text in array2)
		{
			int num = text.Length;
			if (!flag)
			{
				num++;
			}
			if (currentOffset + num >= maxLineLength)
			{
				Console.WriteLine();
				currentOffset = 0;
				flag = true;
			}
			if (flag)
			{
				while (currentOffset < leftMargin)
				{
					Console.Write(' ');
					currentOffset++;
				}
			}
			else
			{
				Console.Write(' ');
				currentOffset++;
			}
			Console.Write(text);
			currentOffset += text.Length;
			flag = false;
		}
		Console.WriteLine();
	}
}
