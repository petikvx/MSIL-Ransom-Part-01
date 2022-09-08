using Microsoft.Win32;

namespace Orcus.Commands.WindowsCustomizer.Core;

public static class Windows10
{
	public static bool LockScreen
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Personalization", writable: false), "NoLockScreen") != 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.LocalMachine, "SOFTWARE\\Policies\\Microsoft\\Windows\\Personalization", "NoLockScreen", (!value) ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool DarkTheme
	{
		get
		{
			int? intValueSafe = RegistryUtilities.GetIntValueSafe(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", writable: false), "AppsUseLightTheme");
			if (intValueSafe.GetValueOrDefault() != 0)
			{
				return false;
			}
			return intValueSafe.HasValue;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", (!value) ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool BalloonNotifications
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", writable: false), "EnableLegacyBalloonNotifications") == 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.CurrentUser, "SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", "EnableLegacyBalloonNotifications", value ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool ActionCenter
	{
		get
		{
			return RegistryUtilities.GetIntValueSafe(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", writable: false), "DisableNotificationCenter") != 1;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.CurrentUser, "SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", "DisableNotificationCenter", (!value) ? 1 : 0, RegistryValueKind.DWord);
		}
	}

	public static bool ClassicVolumeMixer
	{
		get
		{
			int? intValueSafe = RegistryUtilities.GetIntValueSafe(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\MCI32", writable: false), "EnableMtcUvc");
			if (intValueSafe.GetValueOrDefault() != 0)
			{
				return false;
			}
			return intValueSafe.HasValue;
		}
		set
		{
			RegistryUtilities.SetValueSafe(Registry.LocalMachine, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\MCI32", "EnableMtcUvc", (!value) ? 1 : 0, RegistryValueKind.DWord);
		}
	}
}
