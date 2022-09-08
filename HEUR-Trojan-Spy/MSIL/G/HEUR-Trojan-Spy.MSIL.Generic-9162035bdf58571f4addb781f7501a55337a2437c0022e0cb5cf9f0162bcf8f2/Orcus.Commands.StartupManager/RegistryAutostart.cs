using System;
using System.Collections.Generic;
using Microsoft.Win32;
using Orcus.Shared.Commands.StartupManager;

namespace Orcus.Commands.StartupManager;

public static class RegistryAutostart
{
	public static List<AutostartProgramInfo> GetAutostartProgramsFromRegistryKey(AutostartLocation autostartLocation, bool isEnabled)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		List<AutostartProgramInfo> list = new List<AutostartProgramInfo>();
		try
		{
			using RegistryKey registryKey = GetRegistryKeyFromAutostartLocation(autostartLocation, isEnabled, writeable: false);
			if (registryKey != null)
			{
				string[] valueNames = registryKey.GetValueNames();
				foreach (string name in valueNames)
				{
					if (registryKey.GetValue(name) is string commandLine)
					{
						AutostartProgramInfo val = new AutostartProgramInfo();
						val.set_Name(name);
						val.set_CommandLine(commandLine);
						val.set_IsEnabled(isEnabled);
						val.set_AutostartLocation(autostartLocation);
						AutostartProgramInfo autostartProgramInfo = val;
						list.Add(AutostartManager.CompleteAutostartProgramInfo(autostartProgramInfo));
					}
				}
				return list;
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	public static void ChangeAutostartEntry(AutostartLocation autostartLocation, string name, bool isEnabled)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (!isEnabled)
		{
			CreateDisabledSubKey(autostartLocation);
		}
		using RegistryKey registryKey = GetRegistryKeyFromAutostartLocation(autostartLocation, !isEnabled, writeable: true);
		using RegistryKey registryKey2 = GetRegistryKeyFromAutostartLocation(autostartLocation, isEnabled, writeable: true);
		object value = registryKey.GetValue(name);
		registryKey2.SetValue(name, value, RegistryValueKind.String);
		registryKey.DeleteValue(name);
		if (isEnabled && registryKey.ValueCount == 0)
		{
			registryKey2.DeleteSubKey("AutorunsDisabled");
		}
	}

	public static void RemoveAutostartEntry(AutostartLocation autostartLocation, string name, bool isEnabled)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		using (RegistryKey registryKey = GetRegistryKeyFromAutostartLocation(autostartLocation, isEnabled, writeable: true))
		{
			registryKey.DeleteValue(name);
		}
		if (isEnabled)
		{
			return;
		}
		using RegistryKey registryKey2 = GetDisabledSubKey(autostartLocation, writeable: true);
		if (registryKey2 != null && registryKey2.ValueCount == 0)
		{
			using (RegistryKey registryKey3 = GetRegistryKeyFromAutostartLocation(autostartLocation, writeable: true))
			{
				registryKey3.DeleteSubKey("AutorunsDisabled");
				return;
			}
		}
	}

	private static RegistryKey GetRegistryKeyFromAutostartLocation(AutostartLocation autostartLocation, bool writeable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I4, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		return (int)autostartLocation switch
		{
			0 => Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writeable), 
			1 => Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writeable), 
			2 => Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", writeable), 
			_ => throw new ArgumentOutOfRangeException("autostartLocation", autostartLocation, null), 
		};
	}

	private static RegistryKey GetRegistryKeyFromAutostartLocation(AutostartLocation autostartLocation, bool isEnabled, bool writeable)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (!isEnabled)
		{
			return GetDisabledSubKey(autostartLocation, writeable);
		}
		return GetRegistryKeyFromAutostartLocation(autostartLocation, writeable);
	}

	private static RegistryKey GetDisabledSubKey(AutostartLocation autostartLocation, bool writeable)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		using RegistryKey registryKey = GetRegistryKeyFromAutostartLocation(autostartLocation, writeable);
		return registryKey.OpenSubKey("AutorunsDisabled", writeable);
	}

	private static void CreateDisabledSubKey(AutostartLocation autostartLocation)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		using RegistryKey registryKey = GetRegistryKeyFromAutostartLocation(autostartLocation, writeable: true);
		registryKey.CreateSubKey("AutorunsDisabled");
	}
}
