using System;
using System.Collections;
using System.Configuration.Install;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DotNetInstaller;

internal class DotNetInstaller
{
	public static bool RegisterAssemblyForCOM(string strFileName, bool bInstall)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		try
		{
			Assembly assembly = Assembly.LoadFrom(strFileName);
			if ((object)assembly != null)
			{
				RegistrationServices val = new RegistrationServices();
				return val.RegisterAssembly(assembly, AssemblyRegistrationFlags.SetCodeBase);
			}
		}
		catch (ArgumentException)
		{
		}
		catch (Exception)
		{
			return false;
		}
		return false;
	}

	public static bool InstallAssembly(string strFileName, bool bInstall)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		IDictionary dictionary = new Hashtable();
		try
		{
			string[] array = new string[1] { "" };
			AssemblyInstaller.CheckIfInstallable(strFileName);
			AssemblyInstaller val = new AssemblyInstaller(strFileName, array);
			val.set_UseNewContext(true);
			if (bInstall)
			{
				((Installer)val).Install(dictionary);
				((Installer)val).Commit(dictionary);
			}
			else
			{
				((Installer)val).Uninstall(dictionary);
			}
		}
		catch (ArgumentException)
		{
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	[STAThread]
	private static void Main(string[] args)
	{
		bool bInstall = true;
		bool flag = false;
		bool flag2 = false;
		if (args.Length <= 0)
		{
			return;
		}
		string strFileName = args[0];
		if (args.Length > 1)
		{
			for (int i = 1; i < args.Length; i++)
			{
				string text = args[i];
				text = text.ToLower();
				if (text.CompareTo("-u") == 0 || text.CompareTo("/u") == 0)
				{
					bInstall = false;
				}
				if (text.CompareTo("-r") == 0 || text.CompareTo("/r") == 0)
				{
					flag = true;
				}
				if (text.CompareTo("-ur") == 0 || text.CompareTo("/ur") == 0)
				{
					flag2 = true;
				}
			}
		}
		InstallAssembly(strFileName, bInstall);
		if (flag)
		{
			RegisterAssemblyForCOM(strFileName, bInstall: true);
		}
		if (flag2)
		{
			RegisterAssemblyForCOM(strFileName, bInstall: false);
		}
	}
}
