using System;
using System.Runtime.InteropServices;

namespace Fatura;

public static class CpuID
{
	private const int PAGE_EXECUTE_READWRITE = 64;

	public static string getCpuID()
	{
		return ProcessorId();
	}

	[DllImport("user32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr CallWindowProcW([In] byte[] bytes, IntPtr hWnd, int msg, [In][Out] byte[] wParam, IntPtr lParam);

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool VirtualProtect([In] byte[] bytes, IntPtr size, int newProtect, out int oldProtect);

	private static string ProcessorId()
	{
		byte[] result = new byte[8];
		if (!ExecuteCode(ref result))
		{
			return "ND";
		}
		return string.Format("{0}{1}", BitConverter.ToUInt32(result, 4).ToString("X8"), BitConverter.ToUInt32(result, 0).ToString("X8"));
	}

	private static bool ExecuteCode(ref byte[] result)
	{
		byte[] array = new byte[26]
		{
			85, 137, 229, 87, 139, 125, 16, 106, 1, 88,
			83, 15, 162, 137, 7, 137, 87, 4, 91, 95,
			137, 236, 93, 194, 16, 0
		};
		byte[] array2 = new byte[19]
		{
			83, 72, 199, 192, 1, 0, 0, 0, 15, 162,
			65, 137, 0, 65, 137, 80, 4, 91, 195
		};
		int oldProtect;
		if (IsX64Process())
		{
			IntPtr size = new IntPtr(array2.Length);
			if (!VirtualProtect(array2, size, 64, out oldProtect))
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
			}
			return CallWindowProcW(lParam: new IntPtr(result.Length), bytes: array2, hWnd: IntPtr.Zero, msg: 0, wParam: result) != IntPtr.Zero;
		}
		IntPtr size2 = new IntPtr(array.Length);
		if (!VirtualProtect(array, size2, 64, out oldProtect))
		{
			Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
		}
		return CallWindowProcW(lParam: new IntPtr(result.Length), bytes: array, hWnd: IntPtr.Zero, msg: 0, wParam: result) != IntPtr.Zero;
	}

	private static bool IsX64Process()
	{
		return IntPtr.Size == 8;
	}
}
