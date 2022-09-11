using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal static class NativeLibraryHelper
{
	private delegate IntPtr LoadLibraryCallback(string fileName);

	[NonSerialized]
	internal static GetString _008F;

	private static IntPtr LoadLibraryWin32(string fileName)
	{
		return UnsafeNativeMethodsWin32.LoadLibrary(fileName);
	}

	private static IntPtr LoadLibraryPosix(string fileName)
	{
		return UnsafeNativeMethodsPosix.dlopen(fileName, 258);
	}

	public static IntPtr LoadLibrary(string fileName)
	{
		LoadLibraryCallback loadLibraryCallback = LoadLibraryWin32;
		if (!HelperMethods.IsWindows())
		{
			loadLibraryCallback = LoadLibraryPosix;
		}
		return loadLibraryCallback(fileName);
	}

	static NativeLibraryHelper()
	{
		Strings.CreateGetStringDelegate(typeof(NativeLibraryHelper));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008F(107401246), _008F(107401209)), _008F(107401204), _008F(107401199)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008F(107401226)))
		{
			return;
		}
		throw new SecurityException(_008F(107401169));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
