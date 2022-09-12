using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1;

public class CustomLoadLibrary
{
	public static IntPtr GetLoadedModuleAddress(string DLLName)
	{
		ProcessModuleCollection modules = Process.GetCurrentProcess().Modules;
		foreach (ProcessModule item in modules)
		{
			if (item.FileName!.ToLower().EndsWith(DLLName.ToLower()))
			{
				return item.BaseAddress;
			}
		}
		return IntPtr.Zero;
	}

	public static IntPtr GetExportAddress(IntPtr ModuleBase, string ExportName)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			int num = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + 60L));
			Marshal.ReadInt16((IntPtr)(ModuleBase.ToInt64() + num + 20L));
			long num2 = ModuleBase.ToInt64() + num + 24L;
			short num3 = Marshal.ReadInt16((IntPtr)num2);
			long num4 = 0L;
			num4 = ((num3 != 267) ? (num2 + 112L) : (num2 + 96L));
			int num5 = Marshal.ReadInt32((IntPtr)num4);
			int num6 = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + num5 + 16L));
			Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + num5 + 20L));
			int num7 = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + num5 + 24L));
			int num8 = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + num5 + 28L));
			int num9 = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + num5 + 32L));
			int num10 = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + num5 + 36L));
			for (int i = 0; i < num7; i++)
			{
				string text = Marshal.PtrToStringAnsi((IntPtr)(ModuleBase.ToInt64() + Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + num9 + i * 4))));
				if (text.ToLower() == ExportName.ToLower())
				{
					int num11 = Marshal.ReadInt16((IntPtr)(ModuleBase.ToInt64() + num10 + i * 2)) + num6;
					int num12 = Marshal.ReadInt32((IntPtr)(ModuleBase.ToInt64() + num8 + 4 * (num11 - num6)));
					intPtr = (IntPtr)((long)ModuleBase + num12);
					break;
				}
			}
		}
		catch
		{
			throw new InvalidOperationException("Failed to parse module exports.");
		}
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(ExportName + ", export not found.");
		}
		return intPtr;
	}
}
