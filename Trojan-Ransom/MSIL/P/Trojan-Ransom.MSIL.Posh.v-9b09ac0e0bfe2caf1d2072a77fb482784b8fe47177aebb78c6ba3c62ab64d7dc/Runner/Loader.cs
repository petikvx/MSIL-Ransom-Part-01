using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Policy;
using Quest.PowerGUI.ScriptRunner;

namespace Runner;

internal class Loader
{
	[STAThread]
	internal static void Exec(string[] args)
	{
		AppDomain.CurrentDomain.UnhandledException += AppDomain_UnhandledException;
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += AppDomain_AssemblyResolve;
			Exec_0(args);
		}
		catch (Exception ex)
		{
			ShowError(ex.Message);
		}
		finally
		{
			AppDomain.CurrentDomain.AssemblyResolve -= AppDomain_AssemblyResolve;
			AppDomain.CurrentDomain.UnhandledException -= AppDomain_UnhandledException;
		}
	}

	internal static void AppDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		if (e.ExceptionObject is Exception ex)
		{
			ShowError(ex.Message);
		}
	}

	private static void Exec_0(string[] args)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		AppDomain appDomain = null;
		ProductFolder.Init(Assembly.GetExecutingAssembly().Location);
		Program val = new Program(GetResourceManager());
		if (val.get_IsExecuteMode())
		{
			appDomain = CreateAppDomain(args);
			val.Exec(appDomain);
		}
		else
		{
			val.Setup(args);
		}
	}

	private static string GetCmdlineVersion(string[] args)
	{
		bool flag = false;
		int num = 0;
		string text2;
		while (true)
		{
			if (num < args.Length)
			{
				string text = args[num];
				text2 = text.ToLower().Trim();
				if (flag)
				{
					break;
				}
				if (text2 == "-version" || text2 == "/version")
				{
					flag = true;
				}
				num++;
				continue;
			}
			return string.Empty;
		}
		return text2;
	}

	private static AppDomain CreateAppDomain(string[] args)
	{
		AppDomainSetup appDomainSetup = new AppDomainSetup();
		string text = GetCmdlineVersion(args);
		if (string.IsNullOrEmpty(text))
		{
			text = GetResourceManager().GetString("PowerShellVersion");
		}
		if (text == "2.0")
		{
			appDomainSetup.set_ConfigurationFile($"{Path.GetTempPath()}\\{Guid.NewGuid()}.config");
			File.WriteAllText(appDomainSetup.get_ConfigurationFile(), (string)GetResourceManager().GetObject("Posh2.config"));
		}
		AppDomain appDomain = AppDomain.CreateDomain("PowerShellDomain", (Evidence)null, appDomainSetup);
		AppDomainInitialize appDomainInitialize = (AppDomainInitialize)appDomain.CreateInstanceFromAndUnwrap(Assembly.GetEntryAssembly()!.Location, typeof(AppDomainInitialize).FullName);
		appDomainInitialize.Init();
		return appDomain;
	}

	private static ResourceManager GetResourceManager()
	{
		AssemblyName assemblyName = new AssemblyName(Assembly.GetExecutingAssembly().FullName);
		return new ResourceManager(assemblyName.Name, Assembly.GetExecutingAssembly());
	}

	internal static Assembly AppDomain_AssemblyResolve(object sender, ResolveEventArgs args)
	{
		if (args.Name.Contains("ScriptRunner"))
		{
			byte[] rawAssembly = (byte[])GetResourceManager().GetObject("ScriptRunner.dll");
			return Assembly.Load(rawAssembly);
		}
		return null;
	}

	private static void ShowError(string err)
	{
		if (!string.IsNullOrEmpty(err))
		{
			Console.WriteLine(err);
		}
	}
}
