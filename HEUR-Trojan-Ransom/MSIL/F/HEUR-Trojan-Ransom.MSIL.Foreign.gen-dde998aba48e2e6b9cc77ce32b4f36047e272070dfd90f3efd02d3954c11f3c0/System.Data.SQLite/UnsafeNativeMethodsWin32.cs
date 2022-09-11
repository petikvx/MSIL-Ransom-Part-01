using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

[SuppressUnmanagedCodeSecurity]
internal static class UnsafeNativeMethodsWin32
{
	[NonSerialized]
	internal static GetString _0018;

	[DllImport("kernel32", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true, ThrowOnUnmappableChar = true)]
	internal static extern IntPtr LoadLibrary(string fileName);

	static UnsafeNativeMethodsWin32()
	{
		Strings.CreateGetStringDelegate(typeof(UnsafeNativeMethodsWin32));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0018(107401252), _0018(107401215)), _0018(107401210), _0018(107401205)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0018(107401232)))
		{
			return;
		}
		throw new SecurityException(_0018(107401175));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
