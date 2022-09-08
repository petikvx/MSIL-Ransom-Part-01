using System;
using System.Runtime.InteropServices;

namespace Orcus.Utilities;

internal static class AuthenticodeTools
{
	[DllImport("Wintrust.dll")]
	private static extern uint WinVerifyTrust(IntPtr hWnd, IntPtr pgActionID, IntPtr pWinTrustData);

	private static uint WinVerifyTrust(string fileName)
	{
		Guid guid = new Guid("{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}");
		uint num = 0u;
		using WINTRUST_FILE_INFO fileInfo = new WINTRUST_FILE_INFO(fileName, Guid.Empty);
		using UnmanagedPointer unmanagedPointer = new UnmanagedPointer(Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Guid))), AllocMethod.HGlobal);
		using UnmanagedPointer unmanagedPointer2 = new UnmanagedPointer(Marshal.AllocHGlobal(Marshal.SizeOf(typeof(WINTRUST_DATA))), AllocMethod.HGlobal);
		WINTRUST_DATA wINTRUST_DATA = new WINTRUST_DATA(fileInfo);
		IntPtr intPtr = unmanagedPointer;
		IntPtr intPtr2 = unmanagedPointer2;
		Marshal.StructureToPtr((object)guid, intPtr, fDeleteOld: true);
		Marshal.StructureToPtr((object)wINTRUST_DATA, intPtr2, fDeleteOld: true);
		return WinVerifyTrust(IntPtr.Zero, intPtr, intPtr2);
	}

	public static bool IsTrusted(string fileName)
	{
		return WinVerifyTrust(fileName) == 0;
	}
}
