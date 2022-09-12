using System;
using System.Runtime.InteropServices;

namespace Kzzdehomtdt;

public static class NativeMethods
{
	public const int WM_COPYDATA = 74;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, ref CopyData lParam);

	[DllImport("user32")]
	public static extern int RegisterWindowMessage(string message);

	public static IntPtr IntPtrAlloc<T>(T param)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf((object)param));
		Marshal.StructureToPtr((object)param, intPtr, fDeleteOld: false);
		return intPtr;
	}

	public static void IntPtrFree(IntPtr preAllocated)
	{
		if (IntPtr.Zero == preAllocated)
		{
			throw new InvalidOperationException("IntPtr is already 0");
		}
		Marshal.FreeHGlobal(preAllocated);
		preAllocated = IntPtr.Zero;
	}

	public static T GetStruct<T>(IntPtr param)
	{
		return (T)Marshal.PtrToStructure(param, typeof(T));
	}

	public static IntPtr StringToIntPtr(string data)
	{
		return Marshal.StringToHGlobalAnsi(data);
	}

	public static string IntPtrToString(IntPtr data)
	{
		return Marshal.PtrToStringAnsi(data);
	}
}
