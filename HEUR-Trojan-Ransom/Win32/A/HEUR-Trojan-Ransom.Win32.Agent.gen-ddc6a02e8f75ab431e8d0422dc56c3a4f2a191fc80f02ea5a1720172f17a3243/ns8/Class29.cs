using System;
using System.Collections;
using System.Configuration.Install;
using System.ServiceProcess;
using System.Windows.Forms;
using TRM.Service;
using ns5;

namespace ns8;

internal sealed class Class29
{
	public static void smethod_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		TransactedInstaller val = new TransactedInstaller();
		((Installer)val).get_Installers().Add((Installer)(object)new ProjectInstaller());
		((Installer)val).set_Context(new InstallContext("", (string[])null));
		string executablePath = Application.get_ExecutablePath();
		((Installer)val).get_Context().get_Parameters()["assemblypath"] = executablePath;
		((Installer)val).Install((IDictionary)new Hashtable());
	}

	public static bool smethod_1()
	{
		return !Environment.UserInteractive;
	}

	public static void smethod_2()
	{
		ServiceBase[] array = (ServiceBase[])(object)new ServiceBase[1]
		{
			new Class30()
		};
		ServiceBase.Run(array);
	}

	public static void smethod_3(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		try
		{
			ServiceController val = new ServiceController(string_0);
			val.Start();
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_4(string svcName, out bool installed, out bool running)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		installed = false;
		running = false;
		try
		{
			ServiceController val = new ServiceController(svcName);
			running = (int)val.get_Status() == 4;
			installed = true;
		}
		catch (Exception)
		{
			installed = false;
		}
	}
}
