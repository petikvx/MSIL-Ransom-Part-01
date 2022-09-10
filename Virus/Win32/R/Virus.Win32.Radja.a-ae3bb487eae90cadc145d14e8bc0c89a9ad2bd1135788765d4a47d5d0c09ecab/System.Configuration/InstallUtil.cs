using System.Configuration.Install;
using System.Configuration.InstallUtilResources;
using System.Reflection;

namespace System.Configuration;

public class InstallUtil
{
	public static int Main(string[] args)
	{
		Assembly.GetEntryAssembly()!.GetCustomAttributes(typeof(AssemblyProductAttribute), inherit: true);
		Console.WriteLine(Res.GetString("InstallUtilSignOnMessage", "1.0.3705.6018", "Copyright (C) Microsoft Corporation 1998-2001. All rights reserved."));
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
