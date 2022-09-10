using System.Configuration.Install;
using System.Configuration.InstallUtilResources;
using System.Globalization;
using System.Reflection;
using System.Threading;

namespace System.Configuration;

public static class InstallUtil
{
	public static int Main(string[] args)
	{
		Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentUICulture.GetConsoleFallbackUICulture();
		if (Console.OutputEncoding.CodePage != 65001 && Console.OutputEncoding.CodePage != Thread.CurrentThread.CurrentUICulture.TextInfo.OEMCodePage && Console.OutputEncoding.CodePage != Thread.CurrentThread.CurrentUICulture.TextInfo.ANSICodePage)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
		}
		Assembly.GetEntryAssembly()!.GetCustomAttributes(typeof(AssemblyProductAttribute), inherit: true);
		Console.WriteLine(Res.GetString("InstallUtilSignOnMessage", "2.0.50727.42", CommonResStrings.CopyrightForCmdLine));
		try
		{
			ManagedInstallerClass.InstallHelper(args);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return -1;
		}
		return 0;
	}
}
