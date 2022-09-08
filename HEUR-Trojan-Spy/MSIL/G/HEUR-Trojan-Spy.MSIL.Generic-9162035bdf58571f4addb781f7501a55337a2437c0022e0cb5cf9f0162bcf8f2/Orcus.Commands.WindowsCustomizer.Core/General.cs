using System;
using System.IO;
using Microsoft.Win32;

namespace Orcus.Commands.WindowsCustomizer.Core;

public static class General
{
	private static readonly string GodModePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "God-Mode.{ED7BA470-8E54-465E-825C-99712043E01C}");

	public static bool GodMode
	{
		get
		{
			return Directory.Exists(GodModePath);
		}
		set
		{
			if (value)
			{
				Directory.CreateDirectory(GodModePath);
			}
			else
			{
				Directory.Delete(GodModePath);
			}
		}
	}

	public static bool ConfirmFileDelete
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: false), "ConfirmFileDelete") == 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "ConfirmFileDelete", value ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool AutoRebootWithLoggedOnUsers
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", writable: false), "NoAutoRebootWithLoggedOnUsers") != 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.LocalMachine, "SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", "NoAutoRebootWithLoggedOnUsers", (!value) ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool EnableAUAsDefaultShutdownOption
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", writable: false), "NoAUAsDefaultShutdownOption") != 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.LocalMachine, "SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", "NoAUAsDefaultShutdownOption", (!value) ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool EnableWinKeys
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: false), "NoWinKeys") != 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoWinKeys", (!value) ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool EnableInternetOpenWith
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: false), "NoInternetOpenWith") != 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", (!value) ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool AutoReboot
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\CrashControl", writable: false), "AutoReboot") == 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.LocalMachine, "SYSTEM\\CurrentControlSet\\Control\\CrashControl", "AutoReboot", value ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool DoErrorReport
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\PCHealth\\ErrorReporting", writable: false), "DoReport") == 1;
		}
		set
		{
			using RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\PCHealth\\ErrorReporting", RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue("DoReport", value ? 1 : 0, RegistryValueKind.DWord);
			registryKey.SetValue("ShowUI", value ? 1 : 0, RegistryValueKind.DWord);
			registryKey.SetValue("IncludeKernelFaults", value ? 1 : 0, RegistryValueKind.DWord);
			registryKey.SetValue("IncludeMicrosoftApps", value ? 1 : 0, RegistryValueKind.DWord);
			registryKey.SetValue("IncludeWindowsApps", value ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool FilePrintSharing
	{
		get
		{
			if (RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies", writable: false), "NoFileSharing") != 1)
			{
				return RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies", writable: false), "NoPrintSharing") != 1;
			}
			return false;
		}
		set
		{
			using RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies", RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue("NoFileSharing", (!value) ? 1 : 0, RegistryValueKind.DWord);
			registryKey.SetValue("NoPrintSharing", (!value) ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool KernelPaging
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", writable: false), "DisablePagingExecutive") != 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.LocalMachine, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "DisablePagingExecutive", (!value) ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool ClearPageFile
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", writable: false), "ClearPageFileAtShutdown") == 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.LocalMachine, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "ClearPageFileAtShutdown", value ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool BootDefragmentation
	{
		get
		{
			return RegistryUtilities.GetStringValueSafe(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Dfrg\\BootOptimizeFunction", writable: false), "Enable") == "Y";
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.LocalMachine, "SOFTWARE\\Microsoft\\Dfrg\\BootOptimizeFunction", "Enable", value ? "Y" : "N", RegistryValueKind.String);
		}
	}

	public static bool ReserveBandwidthForSystem
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Psched", writable: false), "NonBestEffortLimit") == 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.LocalMachine, "SOFTWARE\\Policies\\Microsoft\\Windows\\Psched", "NonBestEffortLimit", value ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool VerboseLogging
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: false), "VerboseStatus") == 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "VerboseStatus", value ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool SeparateExplorerProcess
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: false), "SeperateProcess") == 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "SeperateProcess", value ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool CrashOnCtrlScroll
	{
		get
		{
			if (RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\kbdhid\\Parameters", writable: false), "CrashOnCtrlScroll") == 1)
			{
				return RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\i8042prt\\Parameters", writable: false), "CrashOnCtrlScroll") == 1;
			}
			return false;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.LocalMachine, "SYSTEM\\CurrentControlSet\\Services\\kbdhid\\Parameters", "CrashOnCtrlScroll", value ? 1 : 0, RegistryValueKind.DWord);
			RegistryUtilities.SetValueSafe(Registry.LocalMachine, "SYSTEM\\CurrentControlSet\\Services\\i8042prt\\Parameters", "CrashOnCtrlScroll", value ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool MobilityCenter
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\MobilityCenter", writable: false), "NoMobilityCenter") != 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\MobilityCenter", "NoMobilityCenter", (!value) ? 1 : 0, RegistryValueKind.DWord);
		}
	}
}
