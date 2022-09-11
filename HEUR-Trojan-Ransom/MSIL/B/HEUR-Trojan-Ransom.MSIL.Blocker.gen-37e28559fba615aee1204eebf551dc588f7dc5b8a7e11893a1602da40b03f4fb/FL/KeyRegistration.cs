using System;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace FL;

[StandardModule]
public sealed class KeyRegistration
{
	public static RegistryKey regedit;

	public static void DeleteGey()
	{
		regedit = Registry.CurrentUser.OpenSubKey("Software\\", writable: true);
		regedit.DeleteValue("MOI");
		regedit.Close();
	}

	public static void DeleteFois()
	{
		regedit = Registry.CurrentUser.OpenSubKey("Software\\", writable: true);
		regedit.DeleteValue("1");
		regedit.Close();
	}

	public static bool ExistsKey()
	{
		if (((ServerComputer)Class3.Class2_0).get_Registry().GetValue("HKEY_CURRENT_USER\\Software", "MOI", (object)null) == null)
		{
			return false;
		}
		return true;
	}

	public static string RegRead()
	{
		try
		{
			regedit = Registry.CurrentUser.OpenSubKey("Software\\", writable: true);
			string result = regedit.GetValue("MOI")!.ToString();
			regedit.Close();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result2 = "error";
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	public static bool smethod_0()
	{
		if (((ServerComputer)Class3.Class2_0).get_Registry().GetValue("HKEY_CURRENT_USER\\Software", "1", (object)null) == null)
		{
			return false;
		}
		return true;
	}

	public static object RegDelete()
	{
		try
		{
			regedit = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			regedit.DeleteValue("JOJA");
			regedit.Close();
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
