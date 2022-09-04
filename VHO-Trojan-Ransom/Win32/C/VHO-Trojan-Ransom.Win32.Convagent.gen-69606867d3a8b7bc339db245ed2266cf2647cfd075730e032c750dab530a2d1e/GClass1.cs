using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;

public class GClass1
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	private struct Struct0
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		internal delegate IntPtr Delegate0(string version);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal delegate IntPtr Delegate1(string version, IntPtr returnCode);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool Delegate2(int pipe, ref GStruct2 message);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool Delegate3(int hSteamPipe, ulong hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		internal delegate bool Delegate4(int pipe);

		internal const uint uint_0 = 8u;

		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr LoadLibraryEx(string string_0, IntPtr intptr_0, uint uint_1);

		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr SetDllDirectory(string string_0);

		internal static TDelegate smethod_0<TDelegate>(IntPtr intptr_0, string string_0) where TDelegate : class
		{
			IntPtr procAddress = GetProcAddress(intptr_0, string_0);
			if (procAddress == IntPtr.Zero)
			{
				return null;
			}
			return (TDelegate)(object)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(TDelegate));
		}
	}

	private static IntPtr intptr_0 = IntPtr.Zero;

	private static Struct0.Delegate1 delegate1_0;

	private static Struct0.Delegate0 delegate0_0;

	private static Struct0.Delegate2 delegate2_0;

	private static Struct0.Delegate4 delegate4_0;

	private static Struct0.Delegate3 delegate3_0;

	private static string smethod_0()
	{
		string result = "";
		try
		{
			result = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Valve\\Steam", "InstallPath", null);
		}
		catch
		{
		}
		return result;
	}

	public static TClass smethod_1<TClass>() where TClass : new()
	{
		if (delegate1_0 == null)
		{
			throw new InvalidOperationException("Steam4NET library has not been initialized.");
		}
		IntPtr intPtr = delegate1_0(Class2.smethod_0(typeof(TClass)), IntPtr.Zero);
		if (intPtr == IntPtr.Zero)
		{
			return default(TClass);
		}
		TClass result = new TClass();
		((GClass3.GInterface0)result).SetupFunctions(intPtr);
		return result;
	}

	public static bool smethod_2()
	{
		return smethod_3();
	}

	private static bool smethod_3()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			return true;
		}
		string text = smethod_0();
		if (!string.IsNullOrEmpty(text))
		{
			Struct0.SetDllDirectory(text + ";" + Path.Combine(text, "bin"));
		}
		text = Path.Combine(text, "steamclient.dll");
		IntPtr intPtr = Struct0.LoadLibraryEx(text, IntPtr.Zero, 8u);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		delegate1_0 = Struct0.smethod_0<Struct0.Delegate1>(intPtr, "CreateInterface");
		if (delegate1_0 == null)
		{
			return false;
		}
		delegate2_0 = Struct0.smethod_0<Struct0.Delegate2>(intPtr, "Steam_BGetCallback");
		if (delegate2_0 == null)
		{
			return false;
		}
		delegate4_0 = Struct0.smethod_0<Struct0.Delegate4>(intPtr, "Steam_FreeLastCallback");
		if (delegate4_0 == null)
		{
			return false;
		}
		delegate3_0 = Struct0.smethod_0<Struct0.Delegate3>(intPtr, "Steam_GetAPICallResult");
		if (delegate3_0 == null)
		{
			return false;
		}
		intptr_0 = intPtr;
		return true;
	}
}
